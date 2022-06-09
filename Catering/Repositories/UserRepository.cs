using Catering.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Catering.Repositories
{
    public static class UserRepository
    {
        public static User FindUserByUsernameAndPassword(string username, string password)
        {
            CateringEntities db = Database.Instance;
            return db.Users.FirstOrDefault(x => x.Username == username && x.UserPassword == password);
        }

        public static bool AnyUserWithFollowingUsername(string username)
        {
            CateringEntities db = Database.Instance;
            return db.Users.Any(x => x.Username == username);
        }

        public static void Insert(User user)
        {
            CateringEntities db = Database.Instance;
            db.Users.Add(user);
            db.SaveChanges();
        }

        public static User[] GetAll()
        {
            CateringEntities db = Database.Instance;
            return db.Users.Include(x => x.Role).ToArray();
        }

        public static User FindUserById(int id)
        {
            CateringEntities db = Database.Instance;
            return db.Users.Find(id);
        }

        public static void Delete(User user)
        {
            CateringEntities db = Database.Instance;
            db.Users.Remove(user);
            db.SaveChanges();
        }
    }
}