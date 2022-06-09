using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catering.Models;

namespace Catering.Factories
{
    public static class UserFactory
    {
        public static User Create(string username, string userPassword, int roleId)
        {
            return new User
            {
                Username = username,
                UserPassword = userPassword,
                RoleId = roleId
            };
        }

        public static User CreateUser(string username, string userPassword)
        {
            return new User
            {
                Username = username,
                UserPassword = userPassword,
                RoleId = 2
            };
        }
    }
}