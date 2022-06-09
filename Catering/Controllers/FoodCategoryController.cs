using Catering.Handlers;
using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Controllers
{
    public static class FoodCategoryController
    {
        public static FoodCategory[] GetAll()
        {
            return FoodCategoryHandler.GetAll();
        }
    }
}