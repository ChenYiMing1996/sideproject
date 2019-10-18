<?php
/**
 * Created by PhpStorm.
 * User: 102601
 * Date: 2019/6/13
 * Time: 上午 12:49
 */
ini_set('display_errors','1');
error_reporting(E_ALL);
header("Content-Type:text/html; charset=utf-8");
$str="Content-Type: text/html; charset=utf8";
session_start();

if($_SESSION["is_login"])
{
    echo"
        <script>
           setTimeout(function() {window.location.href='Post.html';},0);
        </script>";
}
else
{
    echo"請先進行登入";
    echo"
        <script>
           setTimeout(function() {window.location.href='login.html';},1000);
        </script>";
}



?>