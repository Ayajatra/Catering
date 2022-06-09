using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catering.Models;

namespace Catering.Repositories
{
    public static class Database
    {
        public static CateringEntities Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private static Lazy<CateringEntities> instance = new Lazy<CateringEntities>();
    }
}