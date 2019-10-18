<?php
$article_id = $_GET['article_id'];
echo '<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>論壇回文</title>
</head>
<body>
<form name="post" action="old_reply.php?article_id=';echo $article_id; echo'" method="post" id="post">
    <p><input type="submit" name="submit" value="提交回文"></p>
</form>
content
</br>
<textarea rows="10" cols="50" name="content" form="post">
Enter content here...</textarea>
</body>
</html>';
?>