using Catering.Handlers;
using Catering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Catering.Controllers
{
    public static class UserController
    {
        public static User[] GetAll()
        {
            return UserHandler.GetAll();
        }

        public static string DeleteById(int id)
        {
            return UserHandler.DeleteById(id);
        }
    }
}