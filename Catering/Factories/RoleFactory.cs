using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Catering.Models;

namespace Catering.Factories
{
    public static class RoleFactory
    {
        public static Role Create(string name)
        {
            return new Role
            {
                RoleName = name,
            };
        }
    }
}