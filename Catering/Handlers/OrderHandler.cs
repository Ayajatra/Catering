using Catering.Models;
using Catering.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Handlers
{
    public static class OrderHandler
    {
        public static OrderHeader[] GetAllHeaders()
        {
            return OrderRepository.GetAllHeaders();
        }

        public static OrderHeader FindHeaderById(int orderHeaderId)
        {
            return OrderRepository.FindHeaderById(orderHeaderId);
        }

        public static OrderDetail[] GetDetails(int orderHeaderId)
        {
            return OrderRepository.GetDetails(orderHeaderId);
        }

        public static OrderHeader[] GetAllHeadersOfUser(int userId)
        {
            return OrderRepository.GetAllHeadersOfUser(userId);
        }

        public static void AddOrder(int userId, List<OrderDetail> details)
        {
            OrderRepository.AddOrder(userId, details);
        }

        internal static void NotifyPayment(int orderHeaderId)
        {
            OrderRepository.ChangePaymentToOnCheck(orderHeaderId);
        }

        public static void UpdateStatus(int orderHeaderId, int paymentStatusId, int orderStatusId)
        {
            OrderRepository.UpdateStatus(orderHeaderId, paymentStatusId, orderStatusId);
        }
    }
}