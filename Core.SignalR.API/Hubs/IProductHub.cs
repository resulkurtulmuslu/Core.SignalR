using Core.SignalR.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.SignalR.API.Hubs
{
    public interface IProductHub
    {
        Task ReceiveProduct(Product p);
    }
}
