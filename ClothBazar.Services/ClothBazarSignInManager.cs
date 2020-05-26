using ClothBazar.Entities;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ClothBazar.Services
{
   
    public class ClothBazarSignInManager : SignInManager<ClothBazarUser, string>
    {
        public ClothBazarSignInManager(ClothBazarUserManager userManager, IAuthenticationManager authenticationManager)
            : base(userManager, authenticationManager)
        {
        }

        public override Task<ClaimsIdentity> CreateUserIdentityAsync(ClothBazarUser user)
        {
            return user.GenerateUserIdentityAsync((ClothBazarUserManager)UserManager);
        }

        public static ClothBazarSignInManager Create(IdentityFactoryOptions<ClothBazarSignInManager> options, IOwinContext context)
        {
            return new ClothBazarSignInManager(context.GetUserManager<ClothBazarUserManager>(), context.Authentication);
        }
    }
}


