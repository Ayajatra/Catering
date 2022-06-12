using Catering.Handlers;
using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Controllers
{
    public static class OrderStatusController
    {
        public static OrderStatus[] GetAll()
        {
            return OrderStatusHandler.GetAll();
        }
    }
}