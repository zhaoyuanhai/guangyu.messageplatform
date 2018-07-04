using MsgModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsgManagement.Controllers
{
    [Filter.LonginFilter]
    public class ProductListController : BaseController
    {

        // GET: PartnerList
        public ActionResult Index(MsgManagement.Models.PageModel model)
        {
            long total = 0;
            List<Product> list = client.FindPage<Product>(a => a.Language == Language, model.PageIndex, out total);
            model.Count = total;
            model.Url = "/ProductList/index";
            ViewBag.model = model;
            return View(list);
        }
    }
}