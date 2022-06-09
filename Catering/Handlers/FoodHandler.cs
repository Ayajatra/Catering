using Catering.Factories;
using Catering.Models;
using Catering.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Handlers
{
    public static class FoodHandler
    {
        public static Food[] GetAll()
        {
            return FoodRepository.GetAll();
        }

        public static string DeleteById(int id)
        {
            Food food = FoodRepository.FindById(id);
            if (food == null)
                return "Food doesn't exists";

            FoodRepository.Delete(food);
            return null;
        }

        public static void Add(string foodName, int foodPrice, bool foodActiveStatus, int foodCategoryId)
        {
            Food food = FoodFactory.Create(foodName, foodPrice, foodActiveStatus, foodCategoryId);
            FoodRepository.Insert(food);
        }

        public static Food FindById(int foodId)
        {
            return FoodRepository.FindById(foodId);
        }

        public static string Update(int foodId, string foodName, int foodPrice, bool foodActiveStatus, int foodCategoryId)
        {
            Food food = FoodRepository.FindById(foodId);
            if (food == null)
                return "Food doesn't exists";

            food.FoodName = foodName;
            food.FoodPrice = foodPrice;
            food.FoodActiveStatus = foodActiveStatus;
            food.FoodCategoryId = foodCategoryId;
            FoodRepository.Update(food);
            return null;
        }
    }
}