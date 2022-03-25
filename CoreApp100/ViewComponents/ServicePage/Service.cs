using Batu.Repository.Repository;
using Batu.Services.DataServiceLayer;
using DataAccesLayer.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp100.ViewComponents.ServicePage
{
    public class Service: ViewComponent
    {
      private readonly  DataServiceLayer m_dataServiceLayer = new(new DataAcces(new ServiceRepo()));
        //private readonly DataServiceLayer m_dataServiceLayer;
        //public MainPage(DataServiceLayer dataServiceLayer)
        //{
        //    m_dataServiceLayer = dataServiceLayer;

        //}
        public IViewComponentResult Invoke()
        {
            //    var values = m_dataServiceLayer.GetMainPageList();
            return View(m_dataServiceLayer.GetServicePageList());
        }
    }

}
