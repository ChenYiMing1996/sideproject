<?php
include('connect.php');
session_start();
function getAllListCount($db)
{
    $sql = "SELECT * FROM article_list ";
    $DBresult = $db->query($sql);
    return mysqli_num_rows($DBresult);
}
function gstPageNum($db)
{
    $page =ceil(getAllListCount($db)/$_GET['PageSize']);
    return $page;
}
function getIndexData($db)
{
    if(isset($_SESSION["is_login"]))
    {
        $state = $_SESSION["is_login"];
        $account = $_SESSION["user_name"];
    }else{
        $state = false;
        $account = null;
    }
    $Start = ($_GET['Num']-1)*$_GET['PageSize'];
    $Size = $_GET['PageSize'];
    $sql = "SELECT * FROM article_list LIMIT $Start, $Size";
    $DBresult = $db->query($sql);
    if(mysqli_num_rows($DBresult)!=0)
    {
        if($_GET['Type']==="Json")
        {
            header('Content-Type: application/json');
            $Data = array();
            for($i=0; $i<mysqli_num_rows($DBresult); $i++)
            {
                array_push($Data,mysqli_fetch_array($DBresult));
            }
            $JsonString = json_encode([
                "result" => true,
                "array" => mysqli_num_rows($DBresult),
                "allListCount" => getAllListCount($db),
                "page" => gstPageNum($db),
                "account" => $account,
                "state" => $state,
                "data" => $Data
            ]);
            echo $JsonString;
        }
        else
        {
            while ($record = mysqli_fetch_array($DBresult)) {
                $response = $record[$_GET['Type']];
                echo $response;
            }
        }
    }
    else{
        echo "no Data exist";
    }
}
function getArticleData($db)
{
    if(isset($_SESSION["is_login"]))
    {
        $state = $_SESSION["is_login"];
        $account = $_SESSION["user_name"];
    }else{
        $state = false;
        $account = null;
    }
    $id = $_GET['id'];
    //取得標題文章DB
    $sql = "SELECT * FROM article_list WHERE id=$id";
    $article_row = $db->query($sql);
    $article_result = mysqli_fetch_array($article_row);

    $user_id = $article_result["user_id"];
    $sql = "SELECT username FROM user WHERE id= $user_id";
    $username =  mysqli_fetch_array($db->query($sql));
    array_push($article_result,$username);

    $sql = "SELECT * FROM article_reply WHERE targetArticle_id=$id";
    $reply_row = $db->query($sql);
    $reply_result = array();

    for($i = 0; $i < mysqli_num_rows($reply_row); $i++)
    {
        $result = mysqli_fetch_array($reply_row);

        $user_id = $result["user_id"];
        $sql = "SELECT username FROM user WHERE id= $user_id";
        $username =  mysqli_fetch_array($db->query($sql));
        array_push($result,$username);

        array_push($reply_result,$result);
    }



    if(mysqli_num_rows($article_row)==1)
    {
        header('Content-Type: application/json');
        $JsonString = json_encode([
            "result" => true,
            "account" => $account,
            "state" => $state,
            "article_data" => $article_result,
            "reply_data" => $reply_result,
        ]);
        echo $JsonString;
    }
    else{
        echo "no Data exist";
    }
}
function loginfunc($account,$password,$db)
{
    $sql = "select * from user where username = '$account' and password='$password'";
    $result = mysqli_query($db, $sql);
    $rows = mysqli_num_rows($result);
    if ($rows) {
        $_SESSION["is_login"] = true;
        $_SESSION["user_name"] = $account;
        $_SESSION["user_id"] = mysqli_fetch_array($result)[0];
        $JsonString = json_encode([
            "result" => "true",
            "warning" => "",
            "username" => $account,
            "userid" => mysqli_fetch_array($result)[0]
        ]);
        return $JsonString;
    }else
    {
        $JsonString = json_encode([
            "result" => "false",
            "warning" => "帳號密碼錯誤"
        ]);
        return $JsonString;
    }
}
function signupfunc($account,$password,$db)
{
    $sql = "INSERT INTO user(username,password) VALUE('$account','$password')";
    $result = mysqli_query($db, $sql);
    $rows = mysqli_num_rows($result);
    if ($rows) {
        $_SESSION["is_login"] = true;
        $_SESSION["user_name"] = $account;
        $_SESSION["user_id"] = mysqli_fetch_array($result)[0];
        $JsonString = json_encode([
            "result" => "true",
            "warning" =>""
        ]);
        return $JsonString;
    }else
    {
        $JsonString = json_encode([
            "result" => "false",
            "warning" => "註冊失敗"
        ]);
        return $JsonString;
    }
}
function information_missing ()
{
    $JsonString = json_encode([
        "result" => "false",
        "warning" =>"請輸入完整資料"
    ]);
    return $JsonString;
}
function logoutfuc()//清除session並回傳json
{
    $_SESSION["is_login"]=false;
    $_SESSION["user_name"]=null;
    header('Content-Type: application/json');
    $JsonString = json_encode([
        "result" => true,
        "warning" =>"登出完成"
    ]);
    return $JsonString;
}
function postfuc($db)
{
    if(isset($_SESSION["user_id"]))
    {
        $title = $_POST["title"];
        $content = $_POST["content"];
        $content_without_tags = $_POST["content_without_tags"];
        date_default_timezone_set("Asia/Shanghai");
        $posttime = date("Y/m/d");
        $user_id = $_SESSION["user_id"];
        $sql = "INSERT INTO article_list(article,article_without_tags,title,post_time,edit_time,user_id) 
                         VALUE('$content','$content_without_tags','$title','$posttime','$posttime','$user_id')";
        $result = mysqli_query($db, $sql);
        if($result)
        {
            header('Content-Type: application/json');
            $JsonString = json_encode([
                "result" => "true",
                "content" => $content,
                "content_without_tags" => $content_without_tags,
                "title" => $title,
                "posttime" => $posttime,
                "posttime" => $posttime,
                "user_id" => $user_id
            ]);
            return $JsonString;
        }
        else
        {
            header('Content-Type: application/json');
            $JsonString = json_encode([
                "result" => "false",
                "content" => $content,
                "content_without_tags" => $content_without_tags,
                "title" => $title,
                "posttime" => $posttime,
                "posttime" => $posttime,
                "user_id" => $user_id
            ]);
            return $JsonString;
        }

    }
    else {
        header('Content-Type: application/json');
        $JsonString = json_encode([
            "result" => "false",
            "warning" => "請先登入帳號"
        ]);
        return $JsonString;
    }
}
function replyfuc($db)
{
    if(isset($_SESSION["user_id"]))
    {
        $targetArticle_id = $_POST["targetArticle_id"];
        $content = $_POST["content"];
        $content_without_tags = $_POST["content_without_tags"];
        date_default_timezone_set("Asia/Shanghai");
        $posttime = date("Y/m/d");
        $user_id = $_SESSION["user_id"];
        $sql = "INSERT INTO article_reply(targetArticle_id,user_id,content,content_without_tags,post_time,edit_time) 
                         VALUE('$targetArticle_id','$user_id','$content','$content_without_tags','$posttime','$posttime')";
        $result = mysqli_query($db, $sql);
        if($result)
        {
            header('Content-Type: application/json');
            $JsonString = json_encode([
                "result" => "true",
                "targetArticle_id" =>$targetArticle_id,
                "user_id" => $user_id,
                "content" => $content,
                "content_without_tags" => $content_without_tags,
                "post_time" => $posttime,
                "edit_time" => $posttime
            ]);
            return $JsonString;
        }
        else
        {
            header('Content-Type: application/json');
            $JsonString = json_encode([
                "result" => "false",
                "targetArticle_id" => "",
                "user_id" => $user_id,
                "content" => $content,
                "content_without_tags" => $content_without_tags,
                "post_time" => $posttime,
                "edit_time" => $posttime,
                "warning" => "本篇文章已不存在"
            ]);
            return $JsonString;
        }

    }
    else {
        header('Content-Type: application/json');
        $JsonString = json_encode([
            "result" => "false",
            "warning" => "請先登入帳號"
        ]);
        return $JsonString;
    }
}

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    if($_GET['request']==="index")
    {
        $DataType = $_GET['Type'];
        $PageNum = $_GET['Num'];
        $PageSize = $_GET['PageSize'];
        getIndexData($conn);
    }
    if($_GET['request']==="article")
    {
        getArticleData($conn);
    }
}

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    if($_POST['request']==="login")
    {
        if(isset($_POST['account'])){
            if(isset($_POST['password'])){
                header('Content-Type: application/json');
                echo loginfunc($_POST['account'],$_POST['password'],$conn);
            }
            else{
                header('Content-Type: application/json');
                echo information_missing();
            }
        }else {
            header('Content-Type: application/json');
            echo information_missing();
        }
    }
    if($_POST['request']==="signup")
    {
        if(isset($_POST['account'])){
            if(isset($_POST['password'])){
                header('Content-Type: application/json');
                echo signupfunc($_POST['account'],$_POST['password'],$conn);
            }
            else{
                header('Content-Type: application/json');
                echo information_missing();
            }
        }else {
            header('Content-Type: application/json');
            echo information_missing();
        }
    }
    if($_POST['request']==="logout")
    {
        echo logoutfuc();
    }
    if($_POST['request']==="post")
    {
        echo postfuc($conn);
    }
    if($_POST['request']==="reply")
    {
        echo replyfuc($conn);
    }
}

?>
