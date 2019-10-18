<?php
session_start();
include('connect.php');
echo '
<html>
<head>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width,
                                                                 initial-scale=1.0,
                                                                 maximum-scale=1.0,
                                                                 user-scalable=no">
<title>討論版</title>
<link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css">
    <script src="https://cdn.staticfile.org/jquery/2.1.1/jquery.min.js"></script>
    <script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
</head>
<body>';

echo '<div class="container">
    <div class="row">
        <div class="col-md-3 col-xs-6" style="background-color: #F0F8FF">

            <h4>Hi~</h4>
            <h1>'.getUserinfo()["accountState"].'</h1>

        </div>
        <div class="col-md-9 col-xs-6" style="background-color: #F5F5F5">

            <h6>'.getUserinfo()['buttom'].'</h6>

        </div>
     <br><br><br><br>
     <br><br><br><br>
     <br><br><br><br>
        <div class="col-md-12 col-xs-12" style="background-color: #FFFFFF">
            <h1>熱門討論</h1>
        </div>
    </div>

    '.renderContent(getData($conn),$conn).'

</div>';
function getUserinfo()
{
    if ($_SESSION["is_login"]==false or is_null($_SESSION["is_login"]) )
    {
        $username = " ";
        $accountState = "帳號狀態:未登入";
        $buttom = '<form name="post_certify" action="post_certify.php" method="post" >
            <p><input type="submit" name="submit" value="發文"></p>
        </form>
    <form name="post_certify" action="old_login.html" method="post">
            <p><input type="submit" name="submit" value="登入"></p>
        </form>
    <form name="post_certify" action="old_signup.html" method="post">
            <p><input type="submit" name="submit" value="註冊"></p>
        </form>';

    }
    else
    {
        $username = $_SESSION["user_name"];
        $accountState = "帳號狀態:登入中";
        $buttom = '<form name="post_certify" action="post_certify.php" method="post">
            <p><input type="submit" name="submit" value="發文"></p>
        </form>
    <form name="post_certify" action="old_login_out.php" method="post">
            <p><input type="submit" name="submit" value="登出"></p>
        </form>';
    }
    return [
        "username" => $username,
        "accountState" => $accountState,
        "buttom" => $buttom,
    ];
}
function getPageInfo($pageNo = null, $pageSize = 5)
{
    if(is_null($pageNo))
    {
        if(isset($_GET["page"]))
        {
            $pageNo = $_GET["page"];
        }
        else
        {
            $pageNo = 1;
        }
    }
    $recordStart = (($pageNo - 1) * $pageSize);
    return [
        "start" => $recordStart,
        "size" => $pageSize,
    ];
}
function getData($db)
{
    $page = getPageInfo();
    $sql = "SELECT * FROM article_list LIMIT {$page["start"]}, {$page["size"]}";
    $result = $db->query($sql);
    return $result;
}
function renderContent($queryResult,$db)
{
    $page = getPageInfo();
    $totalContent="";
    $dataNum = mysqli_num_rows($queryResult);
    for ($i=0;$i<$dataNum; $i++) {
        $record = mysqli_fetch_array($queryResult);
       // echo '<a href="http://localhost/article.php?id=' . $record['id'] . '">' . $record['title'] . ' </a>';
        $content='
        <div class="row" >
        <div class="col-md-3 col-xs-12" style="background-color: #FFFFFF;">
        <h3>
            <a href="http://localhost/old_article.php?id=' . $record['id'] . '">' . $record['title'] . ' </a>
            </h3>
        </div>

        <div class="col-md-9 col-xs-12" style="background-color: #FFFFFF;box-shadow:
         inset 1px -1px 1px #444, inset -1px 1px 1px #444;">
            <h3>文章內容</h3>
            <p> 內文
            </p>
        </div>
        </div>
        ';
        $totalContent.=$content;
    }
    return $totalContent;
}

function getDataNum($db)
{
    $sql = "SELECT * FROM article_list";
    $result = $db->query($sql);
    $dataNum = mysqli_num_rows($result);
    return $dataNum;
}
function renderPage($queryResult,$db)
{
    $dataNum = getDataNum($db);
    $page = getPageInfo();
    echo "<=============================================================>";
    echo '</br>';
    echo '</br>';
    echo "page";
    echo '</br>';
    for($i=0;$i<=floor(($dataNum-1)/$page["size"]);$i++)
    {
        $count=$i+1;
        echo '<a href="//localhost/index.php?page=' .$count. '">' .$count. '</a>';
        echo '&nbsp;&nbsp;&nbsp;';
    }
}

echo '</body>';
echo '</html>';

?>