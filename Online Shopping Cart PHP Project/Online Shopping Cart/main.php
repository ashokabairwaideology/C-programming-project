<?php
/*  main.php
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
<?php if ($index_refer <> 1) { exit(include("includes/exit.inc.php")); } ?>
<?php
      // if the shop is disabled, the admin can still do everything. let's make sure he/she does not forget it's disabled
      if ($shop_disabled == 1 && IsAdmin() == true) { 
	      PutWindow ($shop_disabled_title,"<font color=red><strong>".$txt['general8']."</strong></font>","warning.gif", "50"); 
          echo "<br /><br />";
      }
?>
  <table width="100%" class="datatable">
    <caption><?php 
   				  echo $txt['main1'];
   				  if (IsAdmin() == true) { echo "[<a href=\"?page=adminedit&filename=main.txt&root=0\">".$txt['browse7']."</a>]"; }
 			 ?>
    </caption>
    <tr><td>
     <?php 
      $fp = fopen($main_file, "rb") or die("Couldn't open ".$main_file.". Make sure it exists and is readable.");
      $main = fread($fp, filesize($main_file));
      fclose($fp);
      echo "<p>".nl2br($main)."</p>";
     ?>
    </td></tr>  
  </table>
  <br />    
    
    <?php
         // Are there any special offers (frontpage=1 in product details)?
         $m_query = "SELECT * FROM `product` WHERE `FRONTPAGE` = '1'";
         $m_sql = mysql_query($m_query) or die(mysql_error());
         if (!mysql_num_rows($m_sql) == 0) {
	        echo "<h2><div style=\"text-align:center;\">".$txt['main2']."</div></h2>";
	        echo "<br />";
            while ($m_row = mysql_fetch_row($m_sql)) {

	              // Read product details
	              $query_details = "SELECT * FROM `product` WHERE `ID`=" . $m_row[0];
	              $sql_details = mysql_query($query_details) or die(mysql_error());
                  while ($row_details = mysql_fetch_row($sql_details)) {
	                    $prod = $m_row[0];
	                    $refermain = 1;  // This is important, because it tells details.php that it was opened by main.php, not browse.php
	                    include ("details.php");
	                    echo "<br /><br />";
                   }
            }
         }
    ?>