<?php
$id = $_GET["id"];
session_start();
include('connect.php');
echo '<html>';
echo '<head>';
echo '<meta charset="UTF-8">';
echo '<title>討論版</title>';
echo '</head>';
echo '<body>';
$result_article = $conn -> query("select * from article_list where id=$id");
$row_article = mysqli_fetch_array( $result_article );
$result_searchUser = $conn -> query("select * from user where id={$row_article['user_id']}");
$row_searchUser = mysqli_fetch_array( $result_searchUser );
if ($_SESSION["is_login"]==false||$_SESSION["is_login"]==null)
{
    echo "想要參與回覆嗎?";
    echo '<form  action="old_login.html" method="post">
            <p><input type="submit" name="submit" value="登入"></p>
        </form>';
    echo '<form  action="old_signup.html" method="post">
            <p><input type="submit" name="submit" value="註冊"></p>
        </form>';
}
else
{
    echo "歡迎你~";
    echo $_SESSION["user_name"] ;
    echo "</br>";
    echo '帳號登入中';
    echo '<form  action="old_login_out.php" method="post">
            <p><input type="submit" name="submit" value="登出"></p>
        </form>';
    echo '<form  action="old_replyForm.php?article_id='; echo $id; echo'" method="post">
            <p><input type="submit" name="submit" value="回文"></p>
        </form>';
}
echo '<br>';
echo '<br>';
echo "發文者:";
echo $row_searchUser['username'];
echo '<br>';
echo '<br>';
echo '<br>';
echo "<=============================================================================================================>";
echo '<br>';
echo "文章內容:";
echo '<br>';
echo $row_article['article'];
echo '<br>';
echo '<br>';
echo "<=============================================================================================================>";
echo '<br>';
echo '<br>';
echo "最後編輯時間:";
echo $row_article['edit_time'];
echo '<br>';
echo '<br>';
echo '<br>';
echo '<br>';
echo '<br>';
echo '<br>';
//<==================================================回文====================================================>
function getPageInfo($pageNo = null, $pageSize = 3)
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
function getReplyData($db)
{
    $id = $_GET["id"];
    $page = getPageInfo();
    $sql = "SELECT * FROM article_reply WHERE targetArticle_id=$id LIMIT {$page["start"]}, {$page["size"]}";
    $result_reply = $db->query($sql);
    return $result_reply;
}
function renderContent($queryResult,$db)
{
    $page = getPageInfo();
    $dataNum = mysqli_num_rows($queryResult);
    for($i=0;$i<$dataNum;$i++)
    {
        $result = mysqli_fetch_array($queryResult);
        echo "回覆者:";
        echo '<br>';
        echo '<br>';
        echo '<br>';
        echo "<=============================================================================================================>";
        echo '<br>';
        echo "文章內容:";
        echo '<br>';
        echo $result['content'];
        echo '<br>';
        echo '<br>';
        echo "<=============================================================================================================>";
        echo '<br>';
        echo '<br>';
        echo "最後編輯時間:";
        echo $result['edit_time'];
        echo '<br>';
        echo '<br>';
        echo '<br>';
        echo '<br>';
        echo '<br>';
        echo '<br>';
    }
    renderPage($queryResult,$db);
}
renderContent(getReplyData($conn),$conn);

function getDataNum($db)
{
    $id = $_GET["id"];
    $sql = "SELECT * FROM article_reply WHERE targetArticle_id=$id";
    $result = $db->query($sql);
    $dataNum = mysqli_num_rows($result);
    return $dataNum;
}

function renderPage($queryResult,$db)
{
    echo "<=============================================================>";
    echo '</br>';
    echo '</br>';
    echo "page";
    echo '</br>';
    $id = $_GET["id"];
    $page = getPageInfo();
    $dataNum = getDataNum($db);
    for($i=0;$i<=floor(($dataNum-1)/$page["size"]);$i++)
    {
        $count=$i+1;
        echo '<a href="//localhost/old_article.php?id=' .$id. ' &page=' .$count. '">' .$count. '</a>';
        echo '&nbsp;&nbsp;&nbsp;';
    }
}


echo '</body>';
echo '</html>';
?>