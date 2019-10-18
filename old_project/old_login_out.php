<?php
session_start();
$_SESSION["is_login"]=false;
$_SESSION["user"]=null;
echo "登出完成";
echo"
        <script>
           setTimeout(function() {window.location.href='index.php';},800);
        </script>";
?>