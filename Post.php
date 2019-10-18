<?php
/*
     <div class="col-md-12 BBlank">
                    <div class="col-md-3" style="padding-bottom: 30px;">
                        <h3>發表新文章</h3>
                    </div>
                    <div class="col-md-3 col-md-offset-6" style="padding-bottom: 30px; margin-top: 20px">
                        <div class="dropdown">
                            <button class="btn btn-default dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">
                                文章發佈
                                <span class="caret"></span>
                            </button>
                            <ul class="dropdown-menu" aria-labelledby="dropdownMenu1">
                                <li><a href="#">文章發佈</a></li>
                                <li><a href="#">整篇刪除</a></li>
                                <li><a href="#">Something else here</a></li>
                            </ul>
                        </div>
                    </div>
                    <div class="col-md-12 ">
                        <form class="form-horizontal">
                            <textarea class="form-control" rows="1" type="text" placeholder="標題主題" ></textarea>
                        </form>
                    </div>
                    <div class=" btn-toolbar col-md-12 magintop15" role="toolbar" aria-label="...">
                        <div class="btn-group" role="group" aria-label="...">
                            <button type="button" class="btn btn-default">
                                <span class="glyphicon glyphicon-paperclip" aria-hidden="true"></span>
                            </button>
                        </div>
                        <div class="btn-group" role="group" aria-label="...">
                            <button type="button" class="btn btn-default">
                                <span class="glyphicon glyphicon-font" aria-hidden="true"></span>
                            </button>
                            <button type="button" class="btn btn-default">
                                <span class="glyphicon glyphicon-bold" aria-hidden="true"></span>
                            </button>
                            <button type="button" class="btn btn-default">
                                <span class="glyphicon glyphicon-italic" aria-hidden="true"></span>
                            </button>
                        </div>
                        <div class="btn-group" role="group" aria-label="...">
                            <button type="button" class="btn btn-default">
                                <span class="glyphicon glyphicon-align-left" aria-hidden="true"></span>
                            </button>
                            <button type="button" class="btn btn-default">
                                <span class="glyphicon glyphicon-align-center" aria-hidden="true"></span>
                            </button>
                            <button type="button" class="btn btn-default">
                                <span class="glyphicon glyphicon-align-right" aria-hidden="true"></span>
                            </button>
                        </div>
                    </div>
                    <div class="col-md-12 ">
                        <form class="form-horizontal">
                            <textarea class="form-control" rows="20" type="text" ></textarea>
                        </form>
                    </div>
                </div>
            </div>
 */
?>
<html>
<head>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/css/bootstrap.min.css"
    <script src="https://cdn.staticfile.org/twitter-bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <script src="jquery-3.4.1.min.js"></script>
    <script src="https://cdn.ckeditor.com/ckeditor5/12.4.0/classic/ckeditor.js"></script>
</head>
<body style="background:#FFFFFF ">
<style>
    .ABlank {
        background: 	#F8F8FF;
        margin-top:15px;
        margin-left:auto;
        margin-right:auto;
        border-bottom: 1px solid #CCDDFF;
        border-radius: 4px;
    }
    .BBlank {
        background:#F5FFFA;
        padding-left: 30px;
        padding-top: 12px ;
        padding-right: 15px ;
        margin-left:auto;
        margin-right:auto;
        border-top: 2px solid #0DBF8C;
        border-bottom: 2px solid #0DBF8C;
        height: 700px;
    }
    .mobileAdHeight
    {
        height: 150px;
    }
    .magintop15
    {
        margin-top: 15px ;
    }
</style>
<div class="container-fluid" >
    <div class="row " style="background:">
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
        <div class="col-md-12" id="t2" style="background:#33E6CC ;height:50px ">
            <p>t2_bar...........</p>
        </div>
    </div>
</div>
<div class="container" >
    <div class="row-fluid" id="base" style="background:#ff5500">
        <div class="row" id="totalABC" style="background:#FFFFFF">
            <div class="col-md-2" id="totalA" style="background: #FFFAFA ;padding-bottom: 15px; margin-top:20px;">
                <div class="ABlank col-md-12 " id="A_toolkitbar" style="">
                    <p>A1</p>
                </div>
                <div class="ABlank col-md-12 hidden-xs hidden-sm " id="A2" style="">
                    <p>A2</p>
                </div>
                <div class="ABlank col-md-12 hidden-xs hidden-sm " id="A3" style="">
                    <p>A3</p>
                </div>
            </div>
            <div class="col-md-7 " id="totalB" style="padding-left:15px; padding-right:15px; margin-top:20px; margin-bottom:40px;">
                <div class="col-md-12 ">

                    <nav class="navbar navbar-default">
                        <div class="input-group" style="margin-bottom: 20px">
                            <span class="input-group-addon" id="basic-addon1">Title</span>
                            <input type="text" class="form-control" id="title" placeholder="輸入標題" aria-describedby="basic-addon1">
                        </div>
                        <textarea  name="content" id="editor" ></textarea>
                        <button type="submit" id="submit" class="btn btn-default">Submit</button>
                    </nav>
                </div>

            </div>
            <div class="col-md-3" id="totalC" style="background:#FFFFF0; margin-top:20px;">
                <div class="col-md-12 col-xs-6 mobileAdHeight" id="C1" style="">
                    <p><img src="img/Ad4.gif" class="img-fluid img-thumbnail" alt="Responsive image">
                </div>
                <div class="col-md-12 col-xs-6 mobileAdHeight" id="C2" style="background:#FFFFFF">
                    <p><img src="img/Ad4.gif" class="img-fluid img-thumbnail" alt="Responsive image">
                </div>
                <div class="col-md-12 col-xs-6 mobileAdHeight" id="C3" style="background:#FFFFFF">
                    <p><img src="img/Ad1.jpg" class="img-fluid img-thumbnail" alt="Responsive image">
                </div>
                <div class="col-md-12 col-xs-6 mobileAdHeight" id="C4" style="background:#FFFFFF">
                    <p><img src="img/Ad2.jpg" class="img-fluid img-thumbnail" alt="Responsive image">
                </div>
                <div class="ABlank col-xs-6 hidden-md hidden-lg mobileAdHeight" id="A2" >
                    <p>A2</p>
                </div>
                <div class="ABlank col-xs-6 hidden-md hidden-lg mobileAdHeight" id="A3" >
                    <p>A3</p>
                </div>
            </div>
        </div>
    </div>
</div>
</body>
</html>

<script src="PostAPI.js"></script>


