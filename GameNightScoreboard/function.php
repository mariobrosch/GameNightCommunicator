<?php

// read a parameter from session, if not avail look into database
function get_par($var) {
	// try to read the settings from session
    if (isset($_SESSION['settings'][$var])) {
		return $_SESSION['settings'][$var];
    } 
	else {
        read_par();
        if (isset($_SESSION['settings'][$var])) {
			return $_SESSION['settings'][$var];
        } 
		else {
      	    print ("<h2>ERROR SETTING NOT FOUND in function get_par(): ".$var."</h2>");
              return false;
        }
    }
}
// read parameterrecord from db
function read_par() {
    global $dbaseName;
    global $dbhandle;
    $query = "Select * FROM $dbaseName.params";
    $userresult = mysqli_query($dbhandle, $query) or die("Query failed: $query<br>\n".
    mysqli_error($dbhandle));
    $query_row = mysqli_fetch_array($userresult);
    $_SESSION['settings'] = $query_row;
}

// get the date
function get_date($TimeZone) {
    $TimeDiff = $TimeZone + date('I'); //If there is a differance between the time off your provider server change the number in your right time zone
    $TimeZoneEpoc = time() - ($TimeDiff * 60 * 60);
    $date = date('d-m-Y G:i', $TimeZoneEpoc);
    return $date;
}

?>