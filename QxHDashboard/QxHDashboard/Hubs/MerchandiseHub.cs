using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using QxHDashboard.Controllers;
using QxHDashboard.Models;
using System.Threading.Channels;

namespace QxHDashboard.Hubs
{
    public class MerchandiseHub : Hub
    {
        private readonly HomeController _homeController;

        public MerchandiseHub(HomeController homeController)
        {
            _homeController = homeController;
        }

        //public IEnumerable<Merchandise> GetAllMerchandise()
        //{
        //    return _homeController.GetAllMerchandise();
        //}

        public ChannelReader<Merchandise> StreamMerchandise()
        {
            return _homeController.StreamMerchandise().AsChannelReader(10);
        }
    }
}
