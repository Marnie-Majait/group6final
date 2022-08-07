<html>
<body>
<?php 
$username = "root"; 
$password = "";
$database = "payroll_database"; 
$conn = new mysqli("localhost", $username, $password, $database); 
$query = "SELECT * FROM time_record";

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}


$result = $conn->query($query);

if ($result->num_rows > 0) {
  echo "<table><tr><th>Employee ID</th><th>Log Date</th><th>Time In</th><th>Before Status</th><th>Time Out</th><th>After Status</th><th>Hours Worked</th></tr>";
  // output data of each row
  while($row = $result->fetch_assoc()) {
    echo "<tr><td>".$row["Employee_Id"]."</td><td>".$row["Log_Date"]." ".$row["Time_in"]." ".$row["Before_Status"]."".$row["Time_Out"]."".$row["After_Status"]."".$row["Hrs_worked"]."</td></tr>";
  }
  echo "</table>";
} else {
  echo "0 results";
}
$conn->close();
?>
</body>
</html>