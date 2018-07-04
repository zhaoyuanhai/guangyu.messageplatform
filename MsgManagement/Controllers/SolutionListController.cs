using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MsgModel;

namespace MsgManagement.Controllers
{
    [Filter.LonginFilter]
    /// <summary>
    /// 解决方案
    /// </summary>
    public class SolutionListController : BaseController
    {
        // GET: SolutionList
        public ActionResult Index(MsgManagement.Models.PageModel model)
        {
            long total = 0;
            List<Solution> list = client.FindPage<Solution>(a => a.Language == Language, model.PageIndex, out total);
            model.Count = total;
            model.Url = "/SolutionList/index";
            ViewBag.model = model;
            return View(list);
        }
    }
}