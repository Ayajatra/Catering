using Catering.Handlers;
using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Controllers
{
    public static class FoodController
    {
        public static Food[] GetAll()
        {
            return FoodHandler.GetAll();
        }

        public static string DeleteById(int id)
        {
            return FoodHandler.DeleteById(id);
        }

        public static string Add(string foodName, string foodPrice, bool foodActiveStatus, int foodCategoryId)
        {
            if (string.IsNullOrWhiteSpace(foodName))
                return "Food name must not be empty";

            if (string.IsNullOrWhiteSpace(foodPrice))
                return "Food price must not be empty";

            if (!int.TryParse(foodPrice, out int foodPriceInt))
                return "Food price must be number";

            if (!FoodCategoryHandler.AnyFoodCategoryWithId(foodCategoryId))
                return "Food category with that id doesn't exists";

            FoodHandler.Add(foodName, foodPriceInt, foodActiveStatus, foodCategoryId);
            return null;
        }

        public static Food FindById(int foodId)
        {
            return FoodHandler.FindById(foodId);
        }

        public static string Update(string foodId, string foodName, string foodPrice, bool foodActiveStatus, int foodCategoryId)
        {
            if (!int.TryParse(foodId, out int foodIdInt))
                return "Food id must be integer";

            if (string.IsNullOrWhiteSpace(foodName))
                return "Food name must not be empty";

            if (string.IsNullOrWhiteSpace(foodPrice))
                return "Food price must not be empty";

            if (!int.TryParse(foodPrice, out int foodPriceInt))
                return "Food price must be number";

            if (!FoodCategoryHandler.AnyFoodCategoryWithId(foodCategoryId))
                return "Food category with that id doesn't exists";

            return FoodHandler.Update(foodIdInt, foodName, foodPriceInt, foodActiveStatus, foodCategoryId);
        }
    }
}