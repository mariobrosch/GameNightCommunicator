<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<?php
//no cache
header("Expires: Mon, 26 Jul 1990 05:00:00 GMT");
header("Last-Modified: " . gmdate("D, d M Y H:i:s") . " GMT");
header("Cache-Control: no-store, no-cache, must-revalidate");
header("Cache-Control: post-check=0, pre-check=0", false);
header("Pragma: no-cache");
?>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <title>GameNight</title>
   <link rel="stylesheet" type="text/css" href="css/style.css" media="screen" />
	<script type="text/javascript" src="js/jquery-3.4.1.min.js"></script>
  <script type="text/javascript"> 
    $(document).ready(function(){
      $("tr:nth-child(odd)").addClass("odd");
      $("tr:nth-child(even)").addClass("even");
    }); 
  </script>
</head>
<body>
<?php

include ("config/config.php");
include ("db.php");
include ("function.php");

print '<div>';
	include ("standings.php");
print '</div>';
?>

</body></html>

