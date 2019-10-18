$(document).ready(function() {
    $.urlParam = function(name) {
        var results = new RegExp('[\\?&]' + name + '=([^&#]*)').exec(window.location.href);
        if (!results) { return 1; }
        return results[1] || 1;
    }//查找class宣告
    var DataType ="Json";//資料Type
    var DataNum = $.urlParam('page');//當前頁碼
    var DatePageSize = 6;//文章最大數
    var myurl = "indexAPI.php?Type=" + DataType + "&Num=" + DataNum + "&PageSize=" + DatePageSize;
    $.ajax({
        url:myurl,
        type:"GET",
        data: {
            "request":"index"
        }
    }).done(
        function (API) {
            pageBarstringPlugin(5);
            console.log("資料是否收到:" + API.result);
            console.log(API.array + "筆陣列");
            console.log(API.page + "頁");
            console.log(API.allListCount + "篇文");
            console.log("帳號狀態:" + API.state );
            console.log(API.account + "的帳號");
            console.log(API);
            var vue = new Vue({
                el: '#content',
                data: {
                    result: API.result,
                    array: API.array,
                    page: API.page,
                    allListCount: API.allListCount,
                    state: API.state,
                    account: API.account
                }
            })
            if(API.state===true)
            {
                var str="\n" +
                    "<li ><a id=\"logout\" href=\"#\">登出</a></li>\n" +
                    "<li id=\"post\"><a href=\"Post.php\">發文</a></li>";
                console.log("帳號登入中");
            }
            else
            {
                var str="<li data-toggle=\"modal\" data-target=\"#loginwindow\"><a href=#\"\">登入</a></li>\n" +
                    "<li data-toggle=\"modal\" data-target=\"#signupwindow\"><a href=#\"\">註冊</a></li>";
            }
            $("#user_dropdown").append(str);
            var Data= API.data;
            for(var i = 0; i < API.array; i++)//迴圈執行內容render
            {
                var blank = "<div class=\"same\" >\n" +
                    "                    <div class=\"col-md-2 col-lg-2\">\n" +
                    "                        <h4>\n" +
                    "                            <a href=\"http://localhost/article.php?id="+Data[i]["id"]+"\"> "+Data[i]["title"].substring(0,20)+"  </a>\n" +
                    "                        </h4>\n" +
                    "                    </div>\n" +
                    "                    <img src=\"img/Ad2.jpg\" class=\"img-fluid img-thumbnail imglLimit col-md-2 col-lg-2\" alt=\"Responsive image\">\n" +
                    "                    <div class=\"col-md-8 col-lg-8\">\n" +
                    "                        <h3>"+ Data[i]["title"] +"</h3>\n" +
                    "                        <p>\n" +
                    "                            "+Data[i]["article_without_tags"].substring(0,130)+"\n" +
                    "                        </p>\n" +
                    "                    </div>\n" +
                    "                </div>";
                $("div.ABlank").append(blank);
            }
            var PageBar ="<div class=\"colcol-md-12\" id=\"pageBar\">\n" +
                "                <nav aria-label=\"Page navigation\">\n" +
                "                    <ul class=\"pagination\">\n" +
                "                        <li>\n" +
                "                            <a href=\"?page="+ 1 +"&type=index\">\n" +
                "                                <span aria-hidden=\"true\">&laquo;</span>\n" +
                "                            </a>\n" +
                "                        </li>\n" +
                 pageBarstringPlugin(5,API.page)
                +
                "                        <li>\n" +
                "                            <a href=\"?page="+ API.page +"&type=index\">\n" +
                "                                <span aria-hidden=\"true\">&raquo;</span>\n" +
                "                            </a>\n" +
                "                        </li>\n" +
                "                    </ul>\n" +
                "                </nav>\n" +
                "            </div>";
            $("div.ABlank").append(PageBar);
            console.log("頁面生成完畢");
        }
    );
/*
    for(var i = 0; i < 10; i++) {
        var input = $("<input id='input-" + i + "' type='text'>");
        var div = $("<div>DIV</div>");
        var button = $("<button value=" + i + "></button>");

        button.text("click me");
        button.on("click", function (el) {
            inputId = $(el.target).val();
            var value = $("#input-" + inputId).val();
        });

        input.val("My Input");
        div.append(input).append(button);
    }*/
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
