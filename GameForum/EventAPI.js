$(document).ready(function(){
})


document.getElementById("btn_login").addEventListener("click", function () {
    var account = document.getElementById("login_account").value;
    var password = document.getElementById("login_password").value;
    var myurl = "indexAPI.php";
    $.ajax({
        url:myurl,
        type: "POST",
        data: {
            "request":"login",
            "account":account,
            "password":password
        }
    }).done(
        function (API) {
            console.log(API.result);
            if(API.result==="true")
            {
                document.getElementById("logout")
                document.getElementById("user_dropdown")
                console.log("登入成功");
            }
            else
            {
                alert("登入失敗" + API.warning);
            }
        }
    )
})
document.getElementById("btn_signup").addEventListener("click", function () {
    var account = document.getElementById("signup_account").value;
    var password = document.getElementById("signup_password").value;
    var myurl = "indexAPI.php";
    $.ajax({
        url:myurl,
        type: "POST",
        data: {
            "request":"signup",
            "account":account,
            "password":password
        }
    }).done(
        function (API) {
            console.log(API.result);
            if(API.result==="true")
            {
                console.log("註冊成功");
            }
            else
            {
                alert("註冊失敗" + API.warning);
            }
        }
    )
})
document.getElementById("logout").addEventListener("click", function () {
    var account = document.getElementById("signup_account").value;
    var password = document.getElementById("signup_password").value;
    var myurl = "indexAPI.php";
    $.ajax({
        url:myurl,
        type: "POST",
        data: {
            "request":"logout"
        }
    }).done(
        function (API) {
            console.log(API);
            if(API.result==="true")
            {
                console.log("登出完成");
            }
            else
            {
                alert("登出失敗" + API.warning);
            }
        }
    )
})