﻿using System.Web;
using System.Web.Mvc;

namespace Biblioteca.UI.Web.Razor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}