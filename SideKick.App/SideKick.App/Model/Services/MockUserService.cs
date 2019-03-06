using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SideKick.App.Model.Contracts;
using SideKick.App.Model.Entities;

namespace SideKick.App.Model.Services
{
    public class MockUserService : IUserService
    {
        public async Task<UserContract> GetUserDetailsAsync()
        {
            return new UserContract() {
                Avatar = "deadpool.png",
                Name = "Deadpool",
                CurrentTimeUtc = DateTime.UtcNow
            };
        }
    }
}
