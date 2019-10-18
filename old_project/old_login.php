<?php
ini_set('display_errors','1');
error_reporting(E_ALL);
header("Content-Type:text/html; charset=utf-8");
$str="Content-Type: text/html; charset=utf8";
session_start();
if(!isset($_POST['submit']))
{
    exit("錯誤執行");
}
include('connect.php');
$name=$_POST['name'];
$password=$_POST['password'];
if($name&&$password)
{
    $sql = "select * from user where username = '$name' and password='$password'";
    $result = mysqli_query($conn,$sql);
    $rows=mysqli_num_rows($result);
    if($rows)
    {
        $_SESSION["is_login"]=true;
        $_SESSION["user_name"]=$name;
        $_SESSION["user_id"] = mysqli_fetch_array($result)[0];
        echo "登入成功";
        echo"
        <script>
           setTimeout(function() {window.location.href='index.php';},800);
        </script>";

        exit;
    }
    else{
        echo"使用者名稱或密碼錯誤";
        echo"
        <script>
           setTimeout(function() {window.location.href='old_login.html';},800);
        </script>";
    }
}
else
{
    echo "表單填寫不完整";
    echo "
    <script>
       setTimeout(function() {window.location.href='old_login.html';},2000);
    </script>";
}
mysqli_close($conn);
?>