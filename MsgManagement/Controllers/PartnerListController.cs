using MsgModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MsgManagement.Controllers
{
    [Filter.LonginFilter]
    /// <summary>
    /// 合作伙伴
    /// </summary>
    public class PartnerListController : BaseController
    {
        // GET: PartnerList
        public ActionResult Index(MsgManagement.Models.PageModel model)
        {
            long total = 0;
            List<CooperativePartner> list = client.FindPage<CooperativePartner>(a => a.Language == Language, model.PageIndex, out total);
            model.Count = total;
            model.Url = "/PartnerList/index";
            ViewBag.model = model;
            return View(list);
        }
    }
}