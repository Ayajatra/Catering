using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Factories
{
    public static class FoodFactory
    {
        public static Food Create(string name, int price, bool activeStatus, int categoryId)
        {
            return new Food
            {
                FoodName = name,
                FoodPrice = price,
                FoodActiveStatus = activeStatus,
                FoodCategoryId = categoryId
            };
        }
    }
}