using System.Web.Mvc;
using MsgModel;
using MsgDAL;
using MsgUI.Models;
using MsgCommon;
using System.Web.Mvc.Html;
using System.IO;
using System;

namespace MsgUI.Controllers
{
    public class HomeController : BaseController
    {
        MongoClient client = new MongoClient();

        public ActionResult Index()
        {
            var model = new IndexModel();

            model.RightImageList = client.Find<IndexImage>(e => e.Language == Language);
            model.HomeText = client.Find<HomeText>(e => e.Language == Language);
            long total;
            model.NewsList = client.FindPage<PressCenter>(e => e.Language == Language, 1, out total, 3);
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(Customer model)
        {
            if (ModelState.IsValid)
            {
                MongoClient client = new MongoClient();
                client.CustomerC.InsertOne(model);

                ViewData.Model = model;
                StringWriter sw = new StringWriter();
                RazorView view = new RazorView(ControllerContext, "~/Views/Shared/EmailTemplate.cshtml", "", false, new[] { "cshtml" });
                ViewContext viewContext = new ViewContext(ControllerContext, view, ViewData, TempData, sw);

                view.Render(viewContext, viewContext.Writer);

                string html = sw.GetStringBuilder().ToString();

                Common.SendEmail("欧华源系统消息", html);
                return Json(new { status = true });
            }
            return Json(new { status = false, error = "类型值不匹配" });
        }
    }
}