﻿using System.Web;
using System.Web.Mvc;

namespace LoginGoogle_FB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
