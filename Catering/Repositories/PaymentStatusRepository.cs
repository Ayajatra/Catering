using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Repositories
{
    public static class PaymentStatusRepository
    {
        public static PaymentStatus[] GetAll()
        {
            CateringEntities db = Database.Instance;

            return db.PaymentStatuses.ToArray();
        }
    }
}