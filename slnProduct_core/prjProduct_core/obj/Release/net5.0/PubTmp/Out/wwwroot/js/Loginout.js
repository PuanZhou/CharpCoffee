let nameval = document.querySelector("#memname");
console.log(nameval);
let loginhref = document.querySelector("#loginID");
console.log(loginhref);
let loguotdiv = document.querySelector("#logoutDiv");

if (nameval.innerHTML != "Login") {
        //如果有登入連結為會員中心
        loginhref.setAttribute("href", "/MemCenter/Index");
        //顯示登出
        loguotdiv.removeAttribute("hidden");
        //$("#loginID").after('<a href="/Home/Logout" id="logoutID"><span id="memname"> 登出</span></a>');
        //console.log($("#loginID"));
    }

    else {   //如果沒登入連結為登入會員
    loginhref.setAttribute("href", "/Home/Login");
        //隱藏登出
    loguotdiv.setAttribute("hidden","");
    }

