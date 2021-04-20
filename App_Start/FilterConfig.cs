﻿using System.Web;
using System.Web.Mvc;

namespace Login
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //dar de alta el filtro
            filters.Add(new Filters.VerifySession());
        }
    }
}
