using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace CoreApp100.Views.Shared.Components.MainPage
{
    public class MainPage: ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
