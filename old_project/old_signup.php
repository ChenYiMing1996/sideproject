<?php
ini_set('display_errors','1');
error_reporting(E_ALL);
header("Content-Type:text/html; charset=utf-8");
if(!isset($_POST['submit']))
{
    exit("錯誤執行,無法post");
}
$name = $_POST['name'];
$password = $_POST['password'];

include('connect.php');

$sql = "INSERT INTO user(username,password) 
VALUE('$name','$password')";

if ($conn->query($sql) === TRUE) {
    echo "註冊成功";
    echo"
        <script>
           setTimeout(function() {window.location.href='index.php';},600);
       </script>";
} else {
    echo "Error: " . $sql . "<br>" . $conn->error;
}

?>