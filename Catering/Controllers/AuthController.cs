using Catering.Handlers;
using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Controllers
{
    public static class AuthController
    {
        public static (User user, string error) Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return (null, "Username is empty");

            if (string.IsNullOrWhiteSpace(password))
                return (null, "Password is empty");

            return UserHandler.Login(username, password);
        }

        public static string Register(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(username))
                return "Username is empty";

            if (string.IsNullOrWhiteSpace(password))
                return "Password is empty";

            if (password != confirmPassword)
                return "Password must be the same as confirm password";

            if (UserHandler.HasUsernameBeenUsed(username))
                return "Username already used";

            UserHandler.Register(username, password);
            return null;
        }
    }
}