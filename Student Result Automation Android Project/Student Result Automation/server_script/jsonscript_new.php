<?php
$hostname = "your_hostname";
$username = "your_username";
$password = "your_password";
$database = "your_database";
$connectioninfo = array("UID"=>$username,"PWD"=>$password,"Database"=>$database);
$link = sqlsrv_connect($hostname,$connectioninfo) or die(print_r(sqlsrv_errors(),true));
$sql = "SELECT * FROM ResAndroid WHERE  Enrollment = '". $_POST["roll"]."' AND Roll = '". $_POST["enroll_number"]."' AND Part = '". $_POST["semester"]."'";
$result = sqlsrv_query($link,$sql) or die("Unable to select: ".sqlsrv_errors());
while($row=sqlsrv_fetch_array($result, SQLSRV_FETCH_ASSOC))
$output[]=$row;
print(json_encode($output));
sqlsrv_close($link);
?>


