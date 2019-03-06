using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SideKick.App.Model.Entities;
using SideKick.App.Model.Services;

namespace SideKick.App.Model.Managers
{
    public class UserManager : IUserManager
    {
        private readonly IUserService _userService;

        public UserManager(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<User> GetUserAsync()
        {
            //DO Processing here if needed
            var response = await _userService.GetUserDetailsAsync();

            return new User()
            {
                Avatar = response.Avatar,
                Name = response.Name,
                LocalTime = response.CurrentTimeUtc.ToLocalTime()
            };
        }
    }
}
