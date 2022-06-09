using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catering.Models;

namespace Catering.Factories
{
    public static class OrderStatusFactory
    {
        public static OrderStatus Create(string name)
        {
            return new OrderStatus
            {
                OrderStatusName = name
            };
        }
    }
}