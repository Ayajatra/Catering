using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Repositories
{
    public static class OrderStatusRepository
    {
        public static OrderStatus[] GetAll()
        {
            CateringEntities db = Database.Instance;

            return db.OrderStatuses.ToArray();
        }
    }
}