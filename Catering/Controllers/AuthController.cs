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

        public static string ChangePassword(User user, string oldPassword, string newPassword, string repeatPassword)
        {
            if (string.IsNullOrWhiteSpace(oldPassword))
                return "Old password can't be empty";

            if (string.IsNullOrWhiteSpace(newPassword))
                return "New password can't be empty";

            if (string.IsNullOrWhiteSpace(repeatPassword))
                return "Repeat password can't be empty";

            if (user.UserPassword != oldPassword)
                return "Old password is wrong";

            if (newPassword != repeatPassword)
                return "New password must match repeat password";


            return UserHandler.UpdatePassword(user.UserId, newPassword);
        }
    }
}