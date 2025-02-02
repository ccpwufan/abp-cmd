namespace AbpCMD.Services
{
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Identity;
    using Volo.Abp.Account;
    using Volo.Abp.Identity;
    using Volo.Abp.DependencyInjection;
    using System.Threading.Tasks;
    using Volo.Abp.Account;
    using Volo.Abp;
    using Microsoft.Extensions.Options;
    using Volo.Abp.Account.Emailing;

    public interface ICustomAccountAppService : IAccountAppService
    {
        Task LoginWithoutPasswordAsync(string username);
    }

    public class CustomAccountAppService : AccountAppService, ICustomAccountAppService, ITransientDependency
    {
        private readonly IdentityUserManager _userManager;
        private readonly SignInManager<Volo.Abp.Identity.IdentityUser> _signInManager;

        public CustomAccountAppService(
            IdentityUserManager userManager,
            SignInManager<Volo.Abp.Identity.IdentityUser> signInManager,
            IIdentityRoleRepository identityRoleRepository,
            IAccountEmailer accountEmailer,
            IdentitySecurityLogManager identitySecurityLogManager,
            IOptions<IdentityOptions> identityOptions)
            : base(userManager, identityRoleRepository, accountEmailer, identitySecurityLogManager, identityOptions)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task LoginWithoutPasswordAsync(string username)
        {
            // 查找用户
            var user = await _userManager.FindByNameAsync(username);
            if (user == null)
            {
                throw new UserFriendlyException("用户不存在！");
            }

            // 使用 SignInManager 登录用户 1q2w3E*
            //await _signInManager.SignInAsync(user, isPersistent: false);

            // 清除会话状态
            await _signInManager.SignOutAsync();

            // 使用 PasswordSignInAsync 登录用户
            var result = await _signInManager.PasswordSignInAsync(user, "1q2w3E*", false, false);


            // 返回成功结果
            return;
        }
    }

}
