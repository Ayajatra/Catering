using Catering.Models;
using Catering.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Handlers
{
    public static class PaymentStatusHandler
    {
        public static PaymentStatus[] GetAll()
        {
            return PaymentStatusRepository.GetAll();
        }
    }
}