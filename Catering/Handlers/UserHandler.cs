using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catering.Factories;
using Catering.Models;
using Catering.Repositories;

namespace Catering.Handlers
{
    public static class UserHandler
    {
        public static (User user, string error) Login(string username, string password)
        {
            User user = UserRepository.FindUserByUsernameAndPassword(username, password);
            if (user == null)
                return (null, "Username or password is wrong");
            else
                return (user, null);
        }

        public static bool HasUsernameBeenUsed(string username)
        {
            return UserRepository.AnyUserWithFollowingUsername(username);
        }

        public static void Register(string username, string password)
        {
            User user = UserFactory.CreateUser(username, password);
            UserRepository.Insert(user);
        }

        public static User[] GetAll()
        {
            return UserRepository.GetAll();
        }

        public static string DeleteById(int id)
        {
            User user = UserRepository.FindUserById(id);
            if (user == null)
                return "User doesn't exists";

            UserRepository.Delete(user);
            return null;
        }
    }
}