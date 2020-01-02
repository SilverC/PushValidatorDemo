using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using PushValidatorDemo.Models;

namespace PushValidatorDemo.Authentication
{
    public class PushValidatorSignInManager : SignInManager<ApplicationUser>
    {
        public PushValidatorSignInManager(UserManager<ApplicationUser> userManager,
           IHttpContextAccessor contextAccessor,
           IUserClaimsPrincipalFactory<ApplicationUser> claimsFactory,
           IOptions<IdentityOptions> optionsAccessor,
           ILogger<SignInManager<ApplicationUser>> logger,
           IAuthenticationSchemeProvider schemes) : base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes)
        { }
    }
}
