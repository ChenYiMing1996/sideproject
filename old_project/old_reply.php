<?php
session_start();
include('connect.php');
function replyInsert($db)
{
    $post_time = date("Y/m/d");
    date_default_timezone_set("Asia/Shanghai");
    $content = $_POST['content'];
    $article_id = $_GET['article_id'];
    $user_id = $_SESSION["user_id"];
    $sql= "INSERT INTO article_reply(targetArticle_id,user_id,content,post_time,edit_time) 
    VALUE ('$article_id','$user_id','$content','$post_time','$post_time')";
    if ($db->query($sql) === TRUE) {
        echo"文章回覆成功";
        echo"
        <script>
           setTimeout(function() {window.location.href='article.php?id=$article_id';},0);
        </script>";
    } else {
        echo"文章回覆失敗,請打上內容";
        echo"
        <script>
           setTimeout(function() {window.location.href='Post.html';},600);
        </script>";
    }
}
replyInsert($conn);
?>

