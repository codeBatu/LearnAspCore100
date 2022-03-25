using Batu.Repository.Repository;
using Batu.Services.DataServiceLayer;
using DataAccesLayer.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp100.ViewComponents.PorfolioPage
{
    public class Portfolio:ViewComponent
    {
        private readonly DataServiceLayer m_dataServiceLayer = new(new DataAcces(new PortfolioRepo()));
        public IViewComponentResult Invoke()
        {
            return View(m_dataServiceLayer.GetPortfolioPageList());
        }
    }
}
