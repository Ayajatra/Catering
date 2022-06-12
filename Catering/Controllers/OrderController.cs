using Catering.Handlers;
using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Controllers
{
    public static class OrderController
    {
        public static OrderHeader[] GetAllHeaders()
        {
            return OrderHandler.GetAllHeaders();
        }

        public static OrderHeader FindHeaderById(int orderHeaderId)
        {
            return OrderHandler.FindHeaderById(orderHeaderId);
        }

        public static OrderDetail[] GetDetails(int orderHeaderId)
        {
            return OrderHandler.GetDetails(orderHeaderId);
        }

        public static OrderHeader[] GetAllHeadersOfUser(int userId)
        {
            return OrderHandler.GetAllHeadersOfUser(userId);
        }

        public static string FinalizeOrder(int userId, List<OrderDetail> cartItems)
        {
            if (cartItems.Count == 0)
                return "Cart item must not be empty";

            if (!UserHandler.AnyUserWithFollowingId(userId))
                return "User doesn't exists";

            OrderHandler.AddOrder(userId, cartItems);
            return null;
        }

        public static void NotifyPayment(int orderHeaderId)
        {
            OrderHandler.NotifyPayment(orderHeaderId);
        }

        public static void UpdateStatus(int orderHeaderId, int paymentStatusId, int orderStatusId)
        {
            OrderHandler.UpdateStatus(orderHeaderId, paymentStatusId, orderStatusId);
        }
    }
}