using Batu.Services.DataServiceLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp100.Controllers
{
    public class DefaultController : Controller
    {
        //private readonly DataServiceLayer m_dataServiceLayer;
        //public DefaultController(DataServiceLayer dataServiceLayer)
        //{
        //    m_dataServiceLayer = dataServiceLayer;
        //}
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
    }
}
