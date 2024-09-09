<?php
/*  install.php
    Copyright 2006 Elmar Wenners
    Support site: http://www.chaozz.nl

    This file is part of FreeWebshop.org.

    FreeWebshop.org is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    FreeWebshop.org is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with FreeWebshop.org; if not, write to the Free Software
    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA

*/
?>
<?php
    // public error printer
    error_reporting(0);
    function PrintError ($message) {
	    echo "<br /><br />";
	    echo "<table border=\"5\" bordercolor=\"red\" cellpadding=\"4\" cellspacing=\"0\"><tr><td><strong>Error:</strong>&nbsp;";
	    echo $message;
	    echo "<br /><br /><a href=\"install.php\">Try again</a>";
	    echo "</td></tr></table>";
	    exit;
    }
    function parse_mysql_dump($url, $ignoreerrors = false) {
        $file_content = file($url);
        //print_r($file_content);
        $query = ""; 
        foreach($file_content as $sql_line) {
          $tsl = trim($sql_line);
          if (($sql_line != "") && (substr($tsl, 0, 2) != "--") && (substr($tsl, 0, 1) != "#")) {
            $query .= $sql_line;
            if(preg_match("/;\s*$/", $sql_line)) {
              $result = mysql_query($query);
              if (!$result && !$ignoreerrors) die(mysql_error());
              $query = "";
            }
          }
        }
    }
    // header printer
    function PrintPageHeader ($header) {
	    echo "<h1><img src=\"gfx/logo_about.gif\" align=\"right\" alt=\"\" />".$header."<hr size=\"5\" noshade color=\"#001894\" width=\"100%\"></h1>";
    }
	    

    // read post values
    $step = 1;
    if (!empty($_POST['step'])) { $step=$_POST['step']; }
    // database values
    if (!empty($_POST['dblocation'])) { $dblocation=$_POST['dblocation']; }
    else { $dblocation = ""; }	    
    if (!empty($_POST['dbname'])) { $dbname=$_POST['dbname']; }
    else { $dbname = ""; }	    
    if (!empty($_POST['dbuser'])) { $dbuser=$_POST['dbuser']; }
    else { $dbuser = ""; }	    
    if (!empty($_POST['dbpass'])) { $dbpass=$_POST['dbpass']; }
    else { $dbpass = ""; }	    
    // smtp values
    if (!empty($_POST['smtp_server'])) { $smtp_server=$_POST['smtp_server']; }
    else { $smtp_server = ""; }	    
    if (!empty($_POST['smtp_port'])) { $smtp_port=$_POST['smtp_port']; }
    else { $smtp_port = ""; }	    
    if (!empty($_POST['smtp_user'])) { $smtp_user=$_POST['smtp_user']; }
    else { $smtp_user = ""; }	    
    if (!empty($_POST['smtp_pass'])) { $smtp_pass=$_POST['smtp_pass']; }
    else { $smtp_pass = ""; }	    
    
    // header
    ?>
    <html>
     <head>
	  <META HTTP-EQUIV="Pragma" CONTENT="no-cache">
	  <META HTTP-EQUIV="Expires" CONTENT="-1">
      <title>FreeWebshop.org installation procedure</title>
     </head>
     <body bgcolor="white">
     <font face="verdana,arial">
    <?php   
    
    if ($step == 1) {
	    // display welcome
	    PrintPageHeader("Thank your for choosing FreeWebshop.org");
	    ?>
	    I will now guide you through the installation of your very own webshop
	    in just a few easy steps.<br />
	    <br />
	    <strong>NOTE:</strong> Please make sure you have read the documentation included in the "docs"
	    folder, concerning copyrights, editting of certain files and more
	    important installation information.<br />
	    <br />
	    Things you need to do before you press 'Next step':
	    <ul>
	     <li>Make <font color="red">a database</font> (write down it's data)</li>
	     <li>Add <font color="red">a user</font> to this database (write down it's data)</li>
	     <li>Make sure <strong>includes\settings.inc.php</strong> is <font color="red">chmodded to 777</font></li>
	     <li>If you are planning on using an SMTP server for sending emails, then make sure you know it's address, port, username and password</li>
	    </ul> 
	    Press <em>'Next step'</em> if you are ready to continue..<br />
	    <br />
	    <form method="post" action="install.php">
	          <input type="hidden" name="step" value="2">
	          <input type="submit" value="Next step">
	    </form>      
	    <?php
    }

    if ($step == 2) {
	    // show form in which database values must be filled in
	    PrintPageHeader("Step 1 - Database access");
	    ?>
	    The first thing we need is access to a database. If you haven't already
	    made one, make one NOW! You need to fill in the proper database values
	    in the form below.<br />
	    <br />
	    <form method="post" action="install.php">
	          <strong>Database values</strong><br />
	          Where is the database located (most common: localhost):<br />
	          <input type="text" name="dblocation" value="localhost"><br />
	          What is the name of the database:<br />
	          <input type="text" name="dbname" value=""><br />
	          What is username to connect to the database:<br />
	          <input type="text" name="dbuser" value=""><br />
	          What is password to connect to the database:<br />
	          <input type="text" name="dbpass" value=""><br />
	          <br />
	          <strong>SMTP values (optional, skip if you're not sure)</strong>
	          What is the address of the SMTP server:<br />
	          <input type="text" name="smtp_server" value=""><br />
	          What is the port of that STMP server:<br />
	          <input type="text" name="smtp_port" value="25"><br />
	          What is username to connect to the SMTP server:<br />
	          <input type="text" name="smtp_user" value=""><br />
	          What is password to connect to the SMTP server:<br />
	          <input type="text" name="smtp_pass" value=""><br />
	          <input type="hidden" name="step" value="3">
	          <input type="submit" value="Next step">
	    </form>      
	    <?php
    }    	    
 
    if ($step == 3) {
       PrintPageHeader("Step 2 - Saving settings");
	   // try to connect to database before writing them to the settings file
	   $db = mysql_connect($dblocation,$dbuser,$dbpass) or die(PrintError ("Could not connect to the database ".$dbname." with the data supplied. Please check the data!"));
 	   mysql_select_db($dbname,$db) or die(PrintError ("Could not connect to the database ".$dbname." with the data supplied. Please check the data!"));
	   echo "Succesfully connected to the database with the values you entered..<br />";
	        // save values to settings.php
	        $nothing = "";
            @chmod("includes/settings.inc.php", 0777);
	        $f=@fopen("includes/settings.inc.php","a");
	        if ($f) {
		        fwrite($f,"\n");
		        fwrite($f,"    // database values\n");
		        fwrite($f,"    $".$nothing."dblocation = \"".$dblocation."\";\n");
		        fwrite($f,"    $".$nothing."dbname = \"".$dbname."\";\n");
		        fwrite($f,"    $".$nothing."dbuser = \"".$dbuser."\";\n");
		        fwrite($f,"    $".$nothing."dbpass = \"".$dbpass."\";\n");
		        fwrite($f,"    \n");
		        fwrite($f,"    // SMTP values (OPTIONAL, LEAVE SERVER EMPTY IF YOU WANT TO USE PHPs MAIL() )\n");
		        fwrite($f,"    $".$nothing."smtp_server = \"".$smtp_server."\";\n");
		        fwrite($f,"    $".$nothing."smtp_port = \"".$smtp_port."\";\n");
		        fwrite($f,"    $".$nothing."smtp_user = \"".$smtp_user."\";\n");
		        fwrite($f,"    $".$nothing."smtp_pass = \"".$smtp_pass."\";\n");
		        fwrite($f,"?>");
		        fclose($f);
		        echo "Values are saved to settings.php!";
		        ?>
	            <br />
	            <form method="post" action="install.php">
	                 <input type="hidden" name="dblocation" value="<?php echo $dblocation; ?>">
	                 <input type="hidden" name="dbname" value="<?php echo $dbname; ?>">
	                 <input type="hidden" name="dbuser" value="<?php echo $dbuser; ?>">
	                 <input type="hidden" name="dbpass" value="<?php echo $dbpass; ?>">
	                 <input type="hidden" name="step" value="4">
	                 <input type="submit" value="Next step">
	            </form>
	            <?php      
            }
            else {
		    // settings.php is not writable
		    PrintError ("includes/settings.inc.php is not writable. Change it's permissions to 777 and try again!");
	    }
    }
    
    if ($step == 4 ) {
	   PrintPageHeader("Step 4 - Make the database structure"); 
	   // connect to database
	   $db = mysql_connect($dblocation,$dbuser,$dbpass) or die(PrintError ("Could not connect to the database ".$dbname." with the data supplied. Please check the data!"));
 	   mysql_select_db($dbname,$db) or die(PrintError ("Could not connect to the database ".$dbname." with the data supplied. Please check the data!"));
 	   
 	   echo "Filling database <strong>".$dbname."</strong> with the correct tables and values..<br /><br />"; 
       // fill database with correct structure	    
       parse_mysql_dump('FreeWebshop.sql', FALSE);
      
       echo "<br /><strong>DONE!</strong><br /><br />";
       echo "You are now ready to start using your brand new webshop. Remember to <strong>delete install.php</strong>!<br /><br />";
       echo "You can now <a href=index.php?page=my>login to your shop</a> using the following data:<br />";
       echo "<strong>username:</strong> admin<br /><strong>password:</strong> admin_1234<br /><br />";
       echo "<font color=red>DON'T FORGET TO CHANGE <strong>THE ADMIN PASSWORD AND EMAIL ADDRESS</strong>!!</font><br /><br />";
       echo "Have fun using your FreeWebshop.org webshop. For support, visit <a href=\"http://www.freewebshop.org\">the FreeWebshop.org homepage</a>.<br />";
       echo "Good luck,<br /> Elmar Wenners";
    }

   // footer
?>
   </font>
   </body>
  </html> 
