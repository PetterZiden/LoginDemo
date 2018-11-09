using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDemo.Models
{
    public class AccountService
    {
        private readonly IdentityDbContext _identityContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountService(IdentityDbContext identityContext, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._identityContext = identityContext;
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public async Task<bool> SignInAsync(string username, string password)
        {
            //Skapar db-tabellerna
            //await _identityContext.Database.EnsureCreatedAsync();
            //Skapa användare
            //var result = await _userManager.CreateAsync(new IdentityUser(username), password);
             
            var result = await _signInManager.PasswordSignInAsync(username, password, false, false);

            return result.Succeeded;
        }
    }
}
