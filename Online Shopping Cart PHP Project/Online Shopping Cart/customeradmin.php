<?php
/*  customeradmin.php
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
<?php include ("checklogin.php"); ?>

<?php
	// admin check
    if (IsAdmin() == false) {
	  PutWindow ($txt['general12'], $txt['general2'], "warning.gif", "50");
	  exit(include("includes/exit.inc.php"));
    }

    $query = "SELECT * FROM `customer` ORDER BY ID ASC";
    $sql = mysql_query($query) or die(mysql_error());

    ?>
    
    <table width="100%" class="datatable">
      <caption><?php echo $txt['customeradmin6']; ?></caption>
     <tr> 
      <th><?php echo $txt['customeradmin1']; ?></th>
      <th><?php echo $txt['customeradmin2']; ?></th>
      <th><?php echo $txt['customeradmin3']; ?></th>
      <th><?php echo $txt['customeradmin4']; ?></th>
      <th><?php echo $txt['customeradmin5']; ?></th>
     </tr>

    <?php
    $color = $tb_pricelist_color2;
    while ($row = mysql_fetch_row($sql)) {
	   echo "<tr>";
	   echo "<td>".$row[3]."</td>";
	   echo "<td>".$row[15]."</td>";
	   echo "<td><a href=\"mailto:".$row[11]."\">".$row[11]."</a></td>";
	   echo "<td>".$row[10]."</td>";
	   echo "<td>";
	   echo "<a href=\"index.php?page=customer&action=show&customerid=".$row[0]."\"><img src=\"".$gfx_dir."/admin_edit.gif\" width=\"16\" height=\"16\" alt=\"Edit\" /></a>";
	   if ($row[12] != "ADMIN") {  
		   // you cannot remove the shop admin even if you wanted it
		   echo "<a href=\"index.php?page=customer&action=delete&customerid=".$row[0]."\"><img src=\"".$gfx_dir."/admin_delete.gif\" width=\"16\" height=\"16\" alt=\"Delete\" /></a>";
	   }
	   echo "<a href=\"index.php?page=orders&id=".$row[0]."\"><img src=\"".$gfx_dir."/admin_orders.gif\" width=\"16\" height=\"16\" alt=\"Orders\" /></a>";
	   echo "<a href=\"index.php?page=cart&action=show&id=".$row[0]."\"><img src=\"".$gfx_dir."/admin_cart.gif\" width=\"16\" height=\"16\" alt=\"Cart\"></a>";
	   echo "<a href=\"javascript:alert('LOGIN: ".$row[1]." | PASSWORD: ".$row[2]."')\"><img src=\"".$gfx_dir."/admin_login.gif\" width=\"16\" height=\"16\" alt=\"Login\"></a>";
	   echo "</td></tr>";
    }
?>
    </table>