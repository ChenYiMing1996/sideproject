

<?php
ini_set('display_errors','1');
error_reporting(E_ALL);
header("Content-Type:text/html; charset=utf-8");
$server="localhost";
$db_username="root";
$db_password="";
$db_name="forum";

$conn = new mysqli($server, $db_username, $db_password, $db_name);

if ($conn->connect_error) {
    exit("Connection failed: " . $conn->connect_error);
}
?>


