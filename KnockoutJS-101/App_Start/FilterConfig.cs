﻿using System.Web;
using System.Web.Mvc;

namespace KnockoutJS_101
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
