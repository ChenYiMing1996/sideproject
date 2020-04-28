
<html>
<head>
    <meta charset="UTF-8">
    <script src="jquery-3.4.1.min.js"></script>
    <script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/vue"></script>
    <script src="https://unpkg.com/axios/dist/axios.min.js"></script>
    <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css"
</head>
<body style="background:#FFFFFF ">
<style>
    .ABlank {
        background:#F5FFFA;
        padding-right: 0px;
        padding-left: 0px;
        padding-top: 12px ;
        padding-bottom: 12px ;
        margin-left:auto;
        margin-right:auto;
        border-top: 2px solid #0DBF8C;
        border-bottom: 2px solid #0DBF8C;
    }
    .same{
        display: -webkit-box;
        display: -webkit-flex;
        display: -ms-flexbox;
        display: flex;
        flex-wrap: wrap;
    }
    .modal-content {
        background-color: #fefefe;
        margin-top: 20px;
        margin-left: auto;
        margin-right: auto;
        padding: 30px;
        width: 40%;
        border: 1px solid #888;
    }
    .imglLimit
    {
        max-width: 600px;
    }
    .test
    {
        box-sizing: border-box;
    }
</style>
<nav class="container-fluid" >
    <div class="row">
        <div class="col-md-12" id="t1" style="background:#20B2AA ;height:80px ;">
            <div class="col-md-3 col-lg-2 col-xs-3 col-sm-3" style="margin-top: 10px">
                <img src="img/1.png" style="height:50px">
            </div>
            <div class="col-md-9 col-lg-9 col-xs-9 col-sm-9">
                <div class="input-group" style="margin-top: 20px">
                    <input type="text" class="form-control" placeholder="全站搜尋">
                    <span class="input-group-btn">
                        <button class="btn btn-default glyphicon glyphicon-search" type="button"></button>
                    </span>
                </div>
            </div>
        </div>
        <div class="" id="t2" style="background:#33E6CC">
            <div class="dropdown ">
                <button class="btn btn-success dropdown-toggle col-md-2" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                    <span id="state" class="glyphicon glyphicon-user" aria-hidden="true">會員狀態:登入</span>
                    <span class="caret"></span>
                </button>
                <div class="col-md-2">
                </div>
                <ul id="user_dropdown" class="dropdown-menu" aria-labelledby="dropdownMenu1">
                    <li role="separator" class="divider"></li>
                    <li id="membercenter"><a href="">會員中心</a></li>
                </ul>
            </div>
        </div>
    </div>
</nav>
<div class="container-fluid" >
    <div class="row" id="content1">
        <div id="md-list-area" class="hidden-lg hidden-md col-xs-12 col-sm-12 ABlank" style="margin-bottom: 30px; box-shadow: 0px 5px 10px #DBE4E8"><script>//內容模板窄型</script>
            <div class="same" >
                <div class="col-md-2 col-lg-2">
                <h4>
                    <a href="http://localhost/article.php?id=1"> title </a>
                </h4>
                </div>
                <img src="img/Ad2.jpg" class="img-fluid img-thumbnail imglLimit col-md-2 col-lg-2" alt="Responsive image">
                <div class="col-md-8 col-lg-8">
                    <h3>title</h3>
                    <p>
                        article_without_tags
                    </p>
                </div>
            </div>
        </div>
    </div>
        <div class="col-md-9 col-v lg-9 hidden-xs hidden-sm" id="totalA" style=" margin-top:20px; margin-bottom:40px;"><script>//內容模板寬型</script>
                <div class="col-md-12 ABlank" style="box-shadow: 0px 5px 10px #DBE4E8">
                    <div class="same" >
                        <div class="col-md-2 col-lg-2">
                            <h4>
                                <a href="http://localhost/article.php?id=1"> title </a>
                            </h4>
                        </div>
                        <img src="img/Ad2.jpg" class="img-fluid img-thumbnail imglLimit col-md-2 col-lg-2" alt="Responsive image">
                        <div class="col-md-8 col-lg-8">
                            <h3>title</h3>
                            <p>
                                article_without_tags
                            </p>
                        </div>
                    </div>
                </div>
        </div>
        <div class="col-md-3 row same col-offset-2.5" id="totalB" style="background:#FFFFFF; margin-top:20px;"><script>//廣告模板</script>
            <div class="col-md-12 col-xs-6 " id="C1" >
                <p><img src="img/Ad4.gif" class="img-fluid img-thumbnail" alt="Responsive image">
            </div>
            <div class="col-md-12 col-xs-6 " id="C2" >
                <p><img src="img/Ad1.jpg" class="img-fluid img-thumbnail" alt="Responsive image">
            </div>
            <div class="col-md-12 col-xs-6 " id="C3" >
                <p><img src="img/Ad2.jpg" class="img-fluid img-thumbnail" alt="Responsive image">
            </div>
            <div class="col-md-12 col-xs-6 " id="C4" >
                <p><img src="img/Ad4.gif" class="img-fluid img-thumbnail" alt="Responsive image">
            </div>
            <div class="col-md-12 col-xs-6 " id="C5" >
                <p><img src="img/Ad4.gif" class="img-fluid img-thumbnail" alt="Responsive image">
            </div>
            <div class="col-md-12 col-xs-6 " id="C6" >
                <p><img src="img/Ad4.gif" class="img-fluid img-thumbnail" alt="Responsive image">
            </div>
        </div>
    </div>
</div>
<div class="container modal fade" id="loginwindow" tabindex="-1">
    <div class="modal-content">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                &times;
            </button>
        </div>
        <div class="modal-body">
            <form method="post" >
                帳號：<input id="login_account" type="text" class="form-control " placeholder="account">
                密碼：<input id="login_password" type="password" class="form-control " placeholder="password">
            </form>
        </div>
        <div class="modal-footer">
            <button type="button" class="btn btn-primary" data-dismiss="modal" data-toggle="modal" data-target="#signupwindow">
                註冊
            </button>
            <button type="button" class="btn btn-primary" data-dismiss="modal" id="btn_login">
                登入
            </button>
        </div>
    </div>
</div>
<div class="container modal fade" id="signupwindow" tabindex="-1">
    <div class="modal-content">
        <div class="modal-header">
            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">
                &times;
            </button>
        </div>
        <div class="modal-body">
            <form method="post" >
                帳號：<input id="signup_account" type="text" class="form-control " placeholder="account">
                密碼：<input id="signup_password" type="password" class="form-control " placeholder="password">
            </form>
        </div>
        <div class="modal-footer">
            <button type="button" class="btn btn-default" data-dismiss="modal">
                關閉
            </button>
            <button type="button" class="btn btn-primary" data-dismiss="modal" id="btn_signup">
                註冊
            </button>
        </div>
    </div>
</div>
<div id="content">
    <renderContent>
    </renderContent>
</div>
</body>
</html>

<script src="index_API.js"></script>
<script src="EventAPI.js"></script>
