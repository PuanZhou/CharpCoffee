using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class OpayController : Controller
    {
        public IActionResult Index()
        {
            string itemName = "衣索比亞 古吉 烏啦嘎 水洗 G1 500元x1 #肯亞 列里 水洗 AA 390元x1";
            string tradeNo = Guid.NewGuid().ToString();
            tradeNo = tradeNo.Substring(tradeNo.Length - 12, 12);
            string timenow = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string checkMacValue = $"HashKey=5294y06JbISpM5x9&ChoosePayment=Credit&ClientBackURL=https://developers.opay.tw/AioMock/MerchantClientBackUrl&CreditInstallment=&EncryptType=1&InstallmentAmount=&ItemName={itemName}&MerchantID=2000132&MerchantTradeDate={timenow}&MerchantTradeNo={tradeNo}&PaymentType=aio&Redeem=&ReturnURL=https://developers.opay.tw/AioMock/MerchantReturnUrl&StoreID=&TotalAmount=890&TradeDesc=建立信用卡測試訂單&HashIV=v77hoKGq4kWxNNIS";
            checkMacValue = System.Web.HttpUtility.UrlEncode(checkMacValue, System.Text.Encoding.UTF8).ToLower();
            using var hash = SHA256.Create();
            var byteArray = hash.ComputeHash(Encoding.UTF8.GetBytes(checkMacValue));
            checkMacValue = Convert.ToHexString(byteArray).ToUpper();

            ViewBag.TradeNO = tradeNo;
            ViewBag.ItemName = itemName;
            ViewBag.CheckMacValue = checkMacValue;
            ViewBag.Timenow = timenow;

            return View();
        }
    }
}
