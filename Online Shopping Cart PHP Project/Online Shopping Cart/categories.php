<?php
/*  submenu.php
    Copyright 2006 Elmar Wenners
    Support site: http://www.chaozz.nl

    This file is part of UltraShop.

    UltraShop is free software; you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation; either version 2 of the License, or
    (at your option) any later version.

    UltraShop is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with UltraShop; if not, write to the Free Software
    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA

*/
?>
<?php if ($index_refer <> 1) { exit(include("includes/exit.inc.php")); } ?>

      <table width="80%" class="datatable">
        <caption><?php echo $txt['submenu1']; ?></caption>
       <tr><td><div style="text-align:center;">
<?php
       $query_cat = "SELECT * FROM `category` WHERE `GROUPID` = " . $group . " ORDER BY `DESC` ASC";
       $sql_cat = mysql_query($query_cat) or die(mysql_error());
       $counter = 0;
       if (mysql_num_rows($sql_cat) == 0) {
           echo $txt['submenu2'];
       }
       else {
	       echo "<table width=\"100%\" class=\"borderless\">"; // a table within a cell
	       while ($row_cat = mysql_fetch_row($sql_cat)) {
	             
		         // count number of products in this category
	             if ($stock_enabled == 1 && IsAdmin() == false) { // filter out products with stock lower than 1
		 	         $query_count = "SELECT `ID` FROM `product` WHERE `STOCK` > 0 AND `CATID`=".$row_cat[0];
	 	         }
	 	         else { $query_count = "SELECT `ID` FROM `product` WHERE `CATID`=".$row_cat[0]; }
    
	             $sql_count = mysql_query($query_count) or die(mysql_error());
	             $prod_num = mysql_num_rows($sql_count);
		       
	             $counter = $counter +1;
		             if ($counter == 1) { echo "<tr><td width=\"33%\" valign=\"top\"><div style=\"text-align:center;\">"; }
	             else { echo "<td width=\"33%\" valign=\"top\"><div style=\"text-align:center;\">"; }
	
	             // determine resize of thumbs
	           	 $thumb = "";
                 $width = "";
                 $height = "";
                 if ($category_thumb_width != 0) { $width = " width=\"".$category_thumb_width."\""; }
                 if ($category_thumb_height != 0) { $height = " height=\"".$category_thumb_height."\""; }
                 
	             if (file_exists($brands_dir."/" . $row_cat[0] . ".jpg")) { $thumb = "<img src=\"".$brands_dir."/" . $row_cat[0] . ".jpg\"".$width.$height." alt=\"\" />"; }
	             if (file_exists($brands_dir."/" . $row_cat[0] . ".gif")) { $thumb = "<img src=\"".$brands_dir."/" . $row_cat[0] . ".gif\"".$width.$height." alt=\"\" />"; }
	             if (file_exists($brands_dir."/" . $row_cat[0] . ".png")) { $thumb = "<img src=\"".$brands_dir."/" . $row_cat[0] . ".png\"".$width.$height." alt=\"\" />"; }
	             if ($thumb == "") { $thumb = "<img src=\"".$gfx_dir."/cat.gif\"".$width.$height." alt=\"\" />"; }
	             echo "<a class=\"plain\" href=\"index.php?page=browse&action=list&group=" . $group . "&cat=" . $row_cat[0] . "&orderby=DESCRIPTION\">".$thumb;
	           	 echo "<br />".$row_cat[1]." (".$prod_num.")</a>";
	             if ($counter == 3) {
	                echo "<br /><br /></div></td></tr>";
	                $counter = 0;
	             }
	             else { echo "<br /><br /></div></td>"; }
	
	       }
	
	      echo "</table>";
      }
      mysql_free_result($sql_cat);
?>
     </td></tr>
    </table>