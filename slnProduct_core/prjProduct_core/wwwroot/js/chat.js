

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    if (message == "") { return };
    let time = new Date();
    let hm = time.getHours() + ":" + (time.getMinutes() < 10 ? '0' : '') + time.getMinutes();
    let head = message.substr(0, 5);
    let body = message.substr(5);

    if (head == "ihtgs") {
        if ($("#userInput")[0].value == user) {
            $("#messagesList").prepend(`<div class="clearfix mt-1">
                                            <img src="${body}" class="w-25 imgAnime" style="float:right"/>
                                        </div>`);
        } else {
            $("#messagesList").prepend(`<div class="clearfix mt-1">
                                            <img src="${body}" class="w-25 imgAnime"/>
                                        </div>`);
        }
    } else {
        if ($("#userInput")[0].value == "李小明") {
            if ($("#userInput")[0].value == user) {
                $("#messagesList").prepend(`<div class="clearfix mt-1">
                                        <div class="shadow rounded p-1 pull-right bg-light">
                                            <h6>${hm}</h6><h4 class="text-success">客服：${message}</h4>
                                        </div>
                                    </div>`);
            }
            else {
                $("#messagesList").prepend(`<div class="clearfix mt-1">
                                        <div class="shadow rounded p-1 pull-left bg-primary">
                                            <h6 class="text-white">${hm}</h6><h4 class="text-black">${user}：${message}</h4>
                                        </div>
                                    </div>`);
            }
        }
        else {
            if ($("#userInput")[0].value == user) {
                $("#messagesList").prepend(`<div class="clearfix mt-1">
                                        <div class="shadow rounded p-1 pull-right bg-light">
                                            <h6>${hm}</h6><h4 class="text-success">您：${message}</h4>
                                        </div>
                                    </div>`);
            }
            else {
                $("#messagesList").prepend(`<div class="clearfix mt-1">
                                        <div class="shadow rounded p-1 pull-left bg-primary">
                                            <h6 class="text-white">${hm}</h6><h4 class="text-black">客服：${message}</h4>
                                        </div>
                                    </div>`);
            }
        }
    }
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    document.getElementById("messageInput").value = "";
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});




