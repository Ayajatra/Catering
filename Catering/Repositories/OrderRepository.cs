using Catering.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Catering.Repositories
{
    public static class OrderRepository
    {
        public static OrderHeader[] GetAllHeaders()
        {
            CateringEntities db = Database.Instance;

            return db.OrderHeaders
                .Include(x => x.User)
                .Include(x => x.OrderStatus)
                .Include(x => x.PaymentStatus)
                .ToArray();
        }

        public static OrderHeader FindHeaderById(int orderHeaderId)
        {
            CateringEntities db = Database.Instance;

            return db.OrderHeaders
                .Include(x => x.User)
                .Include(x => x.OrderStatus)
                .Include(x => x.PaymentStatus)
                .FirstOrDefault(x => x.OrderHeaderId == orderHeaderId);
        }

        public static OrderDetail[] GetDetails(int orderHeaderId)
        {
            CateringEntities db = Database.Instance;

            return db.OrderDetails
                .Include(x => x.Food)
                .Where(x => x.OrderHeaderId == orderHeaderId)
                .ToArray();
        }

        public static OrderHeader[] GetAllHeadersOfUser(int userId)
        {
            CateringEntities db = Database.Instance;

            return db.OrderHeaders
                .Include(x => x.User)
                .Include(x => x.OrderStatus)
                .Include(x => x.PaymentStatus)
                .Where(x => x.UserId == userId)
                .ToArray();
        }

        public static void UpdateStatus(int orderHeaderId, int paymentStatusId, int orderStatusId)
        {
            CateringEntities db = Database.Instance;

            OrderHeader header = db.OrderHeaders.Find(orderHeaderId);
            header.PaymentStatusId = paymentStatusId;
            header.OrderStatusId = orderStatusId;

            db.SaveChanges();
        }

        public static void AddOrder(int userId, List<OrderDetail> details)
        {
            CateringEntities db = Database.Instance;

            OrderHeader header = new OrderHeader
            {
                UserId = userId,
                PaymentStatusId = 1,
                OrderStatusId = 1,
                OrderDate = DateTime.Now,
                OrderDetails = details.Select(x => new OrderDetail
                {
                    FoodId = x.FoodId,
                    FoodQuantity = x.FoodQuantity
                }).ToArray()
            };

            db.OrderHeaders.Add(header);
            db.SaveChanges();
        }

        public static void ChangePaymentToOnCheck(int orderHeaderId)
        {
            CateringEntities db = Database.Instance;

            OrderHeader header = db.OrderHeaders.Find(orderHeaderId);
            header.PaymentStatusId = 2;
            db.SaveChanges();
        }
    }
}