let nameval = document.querySelector("#memname");
let loginhref = document.querySelector("#loginID");
let loguot = document.querySelector("#logout");
let bell = document.querySelector("#notify");

if (nameval.innerHTML != "Login") {//如果有登入
    //連結為會員中心
    loginhref.setAttribute("href", "#");
    //顯示登出
    loguot.removeAttribute("hidden");
    ////顯示小鈴鐺
    bell.removeAttribute("hidden");
    }

    else {   //如果沒登入連結為登入會員
    loginhref.setAttribute("href", "/Home/Login");
        //隱藏登出
    loguot.setAttribute("hidden", "hidden");
    ////隱藏小鈴鐺
    bell.setAttribute("hidden", "");
}

