<?php
/**
 * Created by PhpStorm.
 * User: 102601
 * Date: 2019/6/12
 * Time: 下午 03:21
 */
ini_set('display_errors','1');
error_reporting(E_ALL);
header("Content-Type:text/html; charset=utf-8");
$str="Content-Type: text/html; charset=utf8";
include('connect.php');
session_start();
$post_comment = $_POST['comment'];
$post_title = $_POST['title'];
$username = $_SESSION["user_name"];
$user_id = $_SESSION["user_id"];
date_default_timezone_set("Asia/Shanghai");
$posttime = date("Y/m/d");

if($post_comment&&$post_title)
{
    $sql = "INSERT INTO article_list(article,title,post_time,edit_time,user_id) 
VALUE('$post_comment','$post_title','$posttime','$posttime','$user_id')";
    if ($conn->query($sql) === TRUE) {
        echo"發文成功";
        echo"
        <script>
           setTimeout(function() {window.location.href='index.php';},600);
        </script>";
    } else {
        echo"發文失敗,請打上標題和內容";
        echo"
        <script>
           setTimeout(function() {window.location.href='Post.html';},600);
        </script>";
    }
}

?>