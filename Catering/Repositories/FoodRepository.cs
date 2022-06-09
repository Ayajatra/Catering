using Catering.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Catering.Repositories
{
    public static class FoodRepository
    {
        public static Food[] GetAll()
        {
            CateringEntities db = Database.Instance;
            return db.Foods
                .Include(x => x.FoodCategory)
                .ToArray();
        }

        public static Food FindById(int id)
        {
            CateringEntities db = Database.Instance;
            return db.Foods.Find(id);
        }

        public static void Insert(Food food)
        {
            CateringEntities db = Database.Instance;
            db.Foods.Add(food);
            db.SaveChanges();
        }

        public static void Update(Food food)
        {
            CateringEntities db = Database.Instance;
            db.Entry(food).State = EntityState.Modified;
            db.SaveChanges();
        }

        public static void Delete(Food food)
        {
            CateringEntities db = Database.Instance;
            db.Foods.Remove(food);
            db.SaveChanges();
        }
    }
}