using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace PushValidatorDemo.Authentication
{
    public class PushValidatorTwoFactorTokenProvider<TUser> : IUserTwoFactorTokenProvider<TUser>
        where TUser : class
    {
        Task<bool> IUserTwoFactorTokenProvider<TUser>.CanGenerateTwoFactorTokenAsync(UserManager<TUser> manager, TUser user)
        {
            return Task.FromResult(true);
        }

        Task<string> IUserTwoFactorTokenProvider<TUser>.GenerateAsync(string purpose, UserManager<TUser> manager, TUser user)
        {
            return Task.FromResult("pushvalidator");
        }

        Task<bool> IUserTwoFactorTokenProvider<TUser>.ValidateAsync(string purpose, string token, UserManager<TUser> manager, TUser user)
        {
            return Task.FromResult(true);
        }
    }
}
