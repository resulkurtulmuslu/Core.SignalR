using Core.SignalR.API.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.SignalR.API.Hubs
{
    public class ProductHub : Hub<IProductHub>
    {
        public async Task ReceiveProduct(Product p)
        {
            await Clients.All.ReceiveProduct(p);
        }
    }
}
