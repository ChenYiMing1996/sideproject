$(document).ready(function() {
    $.urlParam = function(name) {
        var results = new RegExp('[\\?&]' + name + '=([^&#]*)').exec(window.location.href);
        if (!results) { return 1; }
        return results[1] || 1;
    }//查找class宣告
    var id = $.urlParam('id');//當前頁碼
    var pagesize = 5;
    var myurl = "indexAPI.php?id=" + id;

    $.ajax({
        url:myurl,
        type:"GET",
        data: {
            "request":"article"
        }
    }).done(
        function (API) {
            console.log(API);
            //pageBarstringPlugin(5);
            console.log("資料是否收到:" + API.result);
            console.log("帳號狀態:" + API.state );
            console.log(API.account + "的帳號");
            var Data= API.article_data;
            var mdArticleStr = "<div class=\"col-md-12  divBottomMargin\" >\n" +
                "                <div class=\"col-md-3 ABlank shadowbloack\" >\n" +
                "                    <p><img src=\"img/20199722112473350.jpg\" class=\"img-fluid img-thumbnail col-md-12 userimglLimit divBottomMargin\" alt=\"Responsive image\">\n" +
                "                    <div class=\" col-md-12\">\n" +
                "                        <h4>"+API.article_data[7][0]+"</h4>\n" +
                "                    </div>\n" +
                "                    <div class=\" col-md-12\">\n" +
                "                        <h4>發文時間:"+API.article_data["post_time"]+"</h4>\n" +
                "                    </div>\n" +
                "                    <div class=\" col-md-12\">\n" +
                "                        <h4>上限狀態:onlinestate</h4>\n" +
                "                    </div>\n" +
                "                </div>\n" +
                "                <div class=\"col-md-9 ABlank shadowbloack\" >\n" +
                "                    <div class=\"col-md-12\">\n" +
                "                        <h2 class=\"underLine\">"+API.article_data["title"]+"</h2>\n" +
                "                    </div>\n" +
                "                    <div class=\"col-md-12\">\n" +
                "                        <h4 >"+API.article_data["article"]+"</h4>\n" +
                "                    </div>\n" +
                "                </div>\n" +
                "            </div>";
            $("#totalA_md").append(mdArticleStr);

            var msArticleStr = "<div class=\"col-xs-12 ABlank shadowbloack divBottomMargin\" >\n" +
                "                <div class=\"col-xs-12 \">\n" +
                "                    <img src=\"img/20199722112473350.jpg\" class=\"same col-xs-4 img-fluid img-thumbnail userimglLimit divBottomMargin\" alt=\"Responsive image\">\n" +
                "                    <div class=\"same col-xs-8\">\n" +
                "                        <div class=\" col-md-12\">\n" +
                "                            <h3>"+API.article_data[7][0]+"</h3>\n" +
                "                        </div>\n" +
                "                        <div class=\" col-md-12\">\n" +
                "                            <h3>發文時間:"+API.article_data["post_time"]+"</h3>\n" +
                "                        </div>\n" +
                "                        <div class=\" col-md-12\">\n" +
                "                            <h3>上限狀態:onlinestate</h3>\n" +
                "                        </div>\n" +
                "                    </div>\n" +
                "                </div>\n" +
                "\n" +
                "                <div class=\"col-xs-12 underLine\" >\n" +
                "                    <h4 >"+API.article_data["title"]+"</h4>\n" +
                "                </div>\n" +
                "                <div class=\"col-xs-12 \" >\n" +
                "                    <h5 >"+API.article_data["article"]+"</h5>\n" +
                "                </div>\n" +
                "            </div>";
            $("#totalA_xs").append(msArticleStr);

            for(var i = 0; i <API.reply_data.length ; i++)
            {
                var mdReplyStr = "<div class=\"col-md-12  divBottomMargin\" >\n" +
                    "                <div class=\"col-md-3 ABlank shadowbloack\" >\n" +
                    "                    <p><img src=\"img/20199722112473350.jpg\" class=\"img-fluid img-thumbnail col-md-12 userimglLimit divBottomMargin\" alt=\"Responsive image\">\n" +
                    "                    <div class=\" col-md-12\">\n" +
                    "                        <h4>"+API.reply_data[i][7][0]+"</h4>\n" +
                    "                    </div>\n" +
                    "                    <div class=\" col-md-12\">\n" +
                    "                        <h4>發文時間:"+API.reply_data[i]["post_time"]+"</h4>\n" +
                    "                    </div>\n" +
                    "                    <div class=\" col-md-12\">\n" +
                    "                        <h4>上限狀態:onlinestate</h4>\n" +
                    "                    </div>\n" +
                    "                </div>\n" +
                    "                <div class=\"col-md-9 ABlank shadowbloack\" >\n" +
                    "                    <div class=\"col-md-12\">\n" +
                    "                        <h4 >"+API.reply_data[i]["content"]+"</h4>\n" +
                    "                    </div>\n" +
                    "                </div>\n" +
                    "            </div>";
                $("#totalA_md").append(mdReplyStr);
            }

            for(var i = 0; i <API.reply_data.length ; i++)
            {
                var msReplyStr = "<div class=\"col-xs-12 ABlank shadowbloack divBottomMargin\" >\n" +
                    "                <div class=\"col-xs-12 \">\n" +
                    "                    <img src=\"img/20199722112473350.jpg\" class=\"same col-xs-4 img-fluid img-thumbnail userimglLimit divBottomMargin\" alt=\"Responsive image\">\n" +
                    "                    <div class=\"same col-xs-8\">\n" +
                    "                        <div class=\" col-md-12\">\n" +
                    "                            <h3>"+API.reply_data[i][7][0]+"</h3>\n" +
                    "                        </div>\n" +
                    "                        <div class=\" col-md-12\">\n" +
                    "                            <h3>發文時間:"+API.reply_data[i]["post_time"]+"</h3>\n" +
                    "                        </div>\n" +
                    "                        <div class=\" col-md-12\">\n" +
                    "                            <h3>上限狀態:onlinestate</h3>\n" +
                    "                        </div>\n" +
                    "                    </div>\n" +
                    "                </div>\n" +
                    "\n" +
                    "                <div class=\"col-xs-12 \" >\n" +
                    "                    <h5 >"+API.reply_data[i]["content"]+"</h5>\n" +
                    "                </div>\n" +
                    "            </div>";
                $("#totalA_xs").append(msReplyStr);
            }

            if(API.state===true)
            {
                var str="\n" +
                    "<li ><a id=\"logout\" href=\"#\">登出</a></li>\n" +
                    "<li id=\"post\"><a href=\"test5.php\">發文</a></li>";
                console.log("帳號登入中");
            }
            else
            {
                var str="<li id=\"login\" data-toggle=\"modal\" data-target=\"#loginwindow\"><a href=#\"\">登入</a></li>\n" +
                    "<li id=\"signup\" data-toggle=\"modal\" data-target=\"#signupwindow\"><a href=#\"\">註冊</a></li>";
            }
            $("#user_dropdown").append(str);
            console.log("頁面生成完畢");
        }
    );
});
function pageBarstringPlugin(btnAmount,pageAmount)
{
    var DataNum = ($.urlParam('page')-2);//當前頁碼
    var str = "";
    for(var i = DataNum; i < (DataNum+btnAmount); i++)
    {
        if(i>0)
        {
            if(i<=pageAmount)
            {
                str = str + "<li><a href=\"?page="+ i +"&type=index\">" + i + "</a></li>";
            }
        }
    }
    return str;
}

