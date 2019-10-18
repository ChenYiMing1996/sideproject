<?php
?>
<html>
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css"
    <script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="jquery-3.4.1.min.js"></script>
    <script src="https://cdn.ckeditor.com/ckeditor5/12.4.0/classic/ckeditor.js"></script>
</head>
<body>
<style>
    .modal-content {
        display: none;
        background-color: #fefefe;
        margin-top: 20px;
        margin-left: auto;
        margin-right: auto;
        padding: 30px;
        width: 40%;
        border: 1px solid #888;
    }
</style>
<div class="container-fluid">
    <button type="button" id="login" class="btn btn-default" style="margin-top: 20px">Login</button>
    <div class="modal-content" id="msgbox">
        <span id="closeBtn" class="glyphicon glyphicon-remove"></span>
        <form method="post" id="form">
            帳號：<input id="account" type="text" class="form-control " placeholder="account">
            密碼：<input id="password" type="password" class="form-control " placeholder="password">
            <p id="submit" class="btn btn-default" style="margin-top: 20px;margin-right: auto">Login</p>
        </form>
    </div>
</div>
</body>
</html>

<script src="PostAPI.js"></script>