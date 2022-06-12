using Catering.Handlers;
using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Controllers
{
    public static class PaymentStatusController
    {
        public static PaymentStatus[] GetAll()
        {
            return PaymentStatusHandler.GetAll();
        }
    }
}