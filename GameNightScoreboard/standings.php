<?php
	include("config/config.php");


	$sql = mysqli_query($dbhandle, "SELECT team.name, team.id FROM team ");
	while ($row = mysqli_fetch_array($sql)) {
		$team = $team.",".$row[0];
		$teamid = $teamid.",".$row[1];
		$num_teams += 1;
	}
	$team = trim($team,",");
	$team = explode(",",$team);
	$teamid = trim($teamid,",");
	$teamid = explode(",",$teamid);
		
	// select number of questions, every team has the same number of records in theory
	$sql = mysqli_query($dbhandle, "SELECT * FROM score WHERE team=1");
	while ($row = mysqli_fetch_array($sql)) {
		$num_matches += 1;
	}

	for ($counter = 1;$counter <= $num_teams; $counter += 1) {
		$id = $teamid[$counter - 1];
		$sql = mysqli_query($dbhandle, "SELECT question, miliseconds, points, fastest
										FROM   score 
										WHERE team='".$id."' 
										");
		{
			$temp_points = 0;
			$temp_miliseconds = 0;
			$temp_fastest = 0;
			$temp_question = 0;
			// loop all scores for this team
			while ($row = mysqli_fetch_array($sql)) {
				$temp_points += $row[2];
				$temp_question += 1;
				$temp_miliseconds += $row[1];
				$temp_fastest += $row[3];
			}
			$points = $points.','.$temp_points;
			$fastest = $fastest.','.$temp_fastest;
			$miliseconds = $miliseconds.",".$temp_miliseconds;
			$question = $question.",".$temp_question;
		}
	}
	$question = trim($question,",");
	$question = explode(",",$question);
	$points = trim($points,",");
	$points = explode(",",$points);
	$miliseconds = trim($miliseconds,",");
	$miliseconds = explode(",",$miliseconds);
	$fastest = trim($fastest,",");
	$fastest = explode(",",$fastest);
		
	// create a temporary table
	$random = rand(10000,99999);
	mysqli_query($dbhandle, "CREATE TABLE tbl_tmp".$random." (name char(25),miliseconds decimal(10,2), points decimal(3,1), questions int, fastest int, PRIMARY KEY (name))");
	for ($counter = 1; $counter <= $num_teams; $counter +=1) {
		$teamid =	$team[$counter - 1];
		$tmp_query= "INSERT INTO tbl_tmp".$random." (name, miliseconds, points, questions, fastest) VALUES ('".$team[$counter -1]."', '".$miliseconds[$counter -1]."', '".$points[$counter - 1]."', '".$question[$counter - 1]."', '".$fastest[$counter-1]."' )";
		mysqli_query ($dbhandle, $tmp_query);
	}
		
	$sql = mysqli_query ($dbhandle, "SELECT name, miliseconds, points, questions, fastest FROM tbl_tmp".$random." ORDER BY points DESC, miliseconds DESC, name ASC");
	$counter = 0;
	print "<table>";
	while ($row = mysqli_fetch_row($sql)) {
		$counter += 1;
		print "<tr><td>".$counter."</td><td>".$row[0]."</td><td>".$row[1]."</td><td>".$row[2]."</td><td>".$row[3]."</td><td>".$row[4]."</td></tr>";
	}		
	print "</table>";
	mysqli_query($dbhandle, "DROP TABLE tbl_tmp".$random." ");
?>
