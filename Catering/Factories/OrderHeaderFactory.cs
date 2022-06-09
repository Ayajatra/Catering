using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catering.Models;

namespace Catering.Factories
{
    public static class OrderHeaderFactory
    {
        public static OrderHeader Create(int userId, int paymentStatusId, int orderStatusId, DateTime orderDate)
        {
            return new OrderHeader
            {
                UserId = userId,
                PaymentStatusId = paymentStatusId,
                OrderStatusId = orderStatusId,
                OrderDate = orderDate
            };
        }
    }
}