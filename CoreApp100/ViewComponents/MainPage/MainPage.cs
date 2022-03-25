using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Batu.Services.DataServiceLayer;
using DataAccesLayer.DAL;
using Batu.Repository.Repository;

namespace CoreApp100.Views.Shared.Components.MainPage
{
    public class MainPage: ViewComponent
    {
private readonly    DataServiceLayer m_dataServiceLayer = new(new DataAcces( new MainPageRepo() ));
        //private readonly DataServiceLayer m_dataServiceLayer;
        //public MainPage(DataServiceLayer dataServiceLayer)
        //{
        //    m_dataServiceLayer = dataServiceLayer;

        //}
        public IViewComponentResult Invoke()
        {
        //    var values = m_dataServiceLayer.GetMainPageList();
            return   View( m_dataServiceLayer.GetMainPageList());
        }
    }
}
