using Catering.Factories;
using Catering.Models;
using Catering.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Handlers
{
    public static class FoodCategoryHandler
    {
        public static FoodCategory[] GetAll()
        {
            return FoodCategoryRepository.GetAll();
        }

        public static bool AnyFoodCategoryWithId(int id)
        {
            return FoodCategoryRepository.AnyWithId(id);
        }
    }
}