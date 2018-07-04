using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MsgDAL;
using MsgModel;
using System.Web.Mvc;

namespace MsgManagement.Controllers
{
    [Filter.LonginFilter]
    public class CustomerController : BaseController
    {
        // GET: Customer
        public ActionResult Index(MsgManagement.Models.PageModel model)
        {
            long total = 0;
            List<Customer> list = client.FindPage<Customer>(a => 1 == 1, model.PageIndex, out total);
            model.Count = total;
            model.Url = "/Customer/index";
            ViewBag.model = model;
            return View(list);
        }
    }
}