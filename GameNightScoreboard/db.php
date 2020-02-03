<?php
global $dbhandle;
$dbhandle = mysqli_connect($dbaseHost, $dbaseUsername, $dbasePassword) or die('I cannot connect to the database');
mysqli_select_db($dbhandle, $dbaseName);
?>