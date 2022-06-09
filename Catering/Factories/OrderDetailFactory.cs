using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catering.Models;

namespace Catering.Factories
{
    public static class OrderDetailFactory
    {
        public static OrderDetail Create(int foodId, int foodQuantity)
        {
            return new OrderDetail
            {
                FoodId = foodId,
                FoodQuantity = foodQuantity
            };
        }
    }
}