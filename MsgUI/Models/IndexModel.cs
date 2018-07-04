using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MsgModel;

namespace MsgUI.Models
{
    public class IndexModel
    {
        public List<IndexImage> RightImageList { get; set; }

        public List<HomeText> HomeText { get; set; }

        public List<PressCenter> NewsList { get; set; }
    }
}