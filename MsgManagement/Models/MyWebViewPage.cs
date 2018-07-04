using MsgModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MsgManagement.Models
{
    public abstract class MyWebViewPage<T> : System.Web.Mvc.WebViewPage<T>
    {
        public LanguageEnum Language
        {
            get
            {
                return (LanguageEnum)HttpContext.Current.Session["Language"];
            }
        }
    }

    public abstract class MyWebViewPage : System.Web.Mvc.WebViewPage
    {
        public LanguageEnum Language
        {
            get
            {
                return (LanguageEnum)HttpContext.Current.Session["Language"];
            }
        }
    }
}