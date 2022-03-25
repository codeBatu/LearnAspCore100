using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Batu.Entites.Concrete;
using Batu.Repository.Repository;
using Batu.Services.DataServiceLayer;
using DataAccesLayer.DAL;

namespace CoreApp100.ViewComponents
{
    public static class InstanceDump
    {
        public static DataServiceLayer m_dataServiceLayer { get; set; }
    }
}
