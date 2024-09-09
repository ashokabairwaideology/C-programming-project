<?php
/*  settings.inc.php
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
    // general settings
    $version = "2.2.1"; // the version of this webshop
    $group = 0;  // default group to open (0 = open main page)
    $index_refer = 1; // pages of the webshop cannot be opened if this value is unset
    error_reporting(E_ALL ^ E_NOTICE);
    
    // file locations (leave default if shop is on same server as all the other files)
    $gfx_dir = "gfx";
    $product_dir = "prodgfx"; // cmod this folder to 777, because we will be uploading images to it
    $brands_dir = "cats";
    $orders_dir = "orders"; // chmod this folder to 777, because the shop needs to write in it
    $lang_dir = "langs";
    $themes_dir = "themes";
    
    // if this is a clean install, then YES there is a part missing at the end of this file. 
    // But it will be added during installation
