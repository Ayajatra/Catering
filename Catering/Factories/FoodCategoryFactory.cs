using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catering.Models;

namespace Catering.Factories
{
    public static class FoodCategoryFactory
    {
        public static FoodCategory Create(string name)
        {
            return new FoodCategory
            {
                FoodCategoryName = name,
            };
        }
    }
}