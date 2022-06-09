using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Repositories
{
    public static class FoodCategoryRepository
    {
        public static FoodCategory[] GetAll()
        {
            CateringEntities db = Database.Instance;
            return db.FoodCategories.ToArray();
        }

        public static bool AnyWithId(int id)
        {
            CateringEntities db = Database.Instance;
            return db.FoodCategories.Any(x => x.FoodCategoryId == id);
        }
    }
}