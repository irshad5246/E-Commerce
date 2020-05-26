using ClothBazar.Database;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
   
    public class ClothBazarRoleManager : RoleManager<IdentityRole>
    {
        public ClothBazarRoleManager(IRoleStore<IdentityRole, string> roleStore) : base(roleStore)
        {

        }
        public static ClothBazarRoleManager Create(IdentityFactoryOptions<ClothBazarRoleManager> options, IOwinContext context)
        {
            return new ClothBazarRoleManager(new RoleStore<IdentityRole>(context.Get<CBContext>()));
        }
    }
}

