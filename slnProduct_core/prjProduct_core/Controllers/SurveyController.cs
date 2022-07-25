using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Microsoft.AspNetCore.Mvc;
using prjProduct_core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjProduct_core.Controllers
{
    public class SurveyController : Controller
    {
        private readonly CoffeeContext db;

        public SurveyController(CoffeeContext context)
        {
            db = context;
        }

        private readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };

        private readonly string ApplicationName = "QAresult";

        private readonly string SpreadsheetId = "1_FU8ssK_V0CbPWC42dU3JvZPYuR_DEBZAN91Bhcy8HQ";

        private readonly string sheet = "問卷回復";

        private SheetsService service;

        public IActionResult List()
        {
            LoadGoogleSheet();
            var tradeno = db.Surveys.Select(x => x.TradeNo).ToList();
            var survery = db.Orders.Where(p => tradeno.Contains(p.TradeNo) && p.OrderStateId == 3 && p.SurveyCoupon == false).ToList();
            if (survery != null && survery.Count > 0)
            {
                return View(survery);
            }
            return Content("null", "text/plain", Encoding.UTF8);
        }

        public IActionResult SentCoupon()
        {
            var tradeno = db.Surveys.Select(x => x.TradeNo).ToList();
            var survery = db.Orders.Where(p => tradeno.Contains(p.TradeNo) && p.OrderStateId == 3 && p.SurveyCoupon == false).ToList();
            foreach (Order order in survery)
            {
                order.SurveyCoupon = true;
                CouponDetail couponDetail = new CouponDetail();
                couponDetail.MemberId = order.MemberId;
                couponDetail.CouponId = 3;
                db.CouponDetails.Add(couponDetail);
                db.SaveChanges();
                return Content("Saved", "text/plain", Encoding.UTF8);
            }
            return Content("null", "text/plain", Encoding.UTF8);
        }



        private void ClearSurvey()
        {
            var range = $"{sheet}!A2:O";
            var request = new ClearValuesRequest();

            var deleteRequest = service.Spreadsheets.Values.Clear(request, SpreadsheetId, range);
            deleteRequest.Execute();
        }

        private void LoadGoogleSheet()
        {
            GoogleCredential credential;

            using (var stream = new FileStream("charpcoffee.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream).CreateScoped(Scopes);
            }

            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            var range = $"{sheet}!C2:C";
            var request = service.Spreadsheets.Values.Get(SpreadsheetId, range);

            var response = request.Execute();
            var values = response.Values;
            if (values != null && values.Count > 0)
            {
                foreach (var row in values)
                {
                    if (row.Count != 0)
                    {
                        Survey survey = new Survey();
                        survey.TradeNo = row[0].ToString();
                        db.Surveys.Add(survey);
                        db.SaveChanges();
                    }
                }
                ClearSurvey();
            }
        }
    }
}
