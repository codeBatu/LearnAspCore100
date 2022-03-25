using Batu.Repository.Repository;
using Batu.Services.DataServiceLayer;
using DataAccesLayer.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp100.ViewComponents.About
{
    public class About: ViewComponent
    {
        private readonly DataServiceLayer m_dataServiceLayer = new(new DataAcces(new AboutRepository()));
     
        public IViewComponentResult Invoke()
        {
           
            return View(m_dataServiceLayer.GetAboutPageList());
        }
    }
}
