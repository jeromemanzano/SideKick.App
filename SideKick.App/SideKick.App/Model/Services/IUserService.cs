using SideKick.App.Model.Contracts;
using SideKick.App.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SideKick.App.Model.Services
{
    public interface IUserService
    {
        Task<UserContract> GetUserDetailsAsync();
    }
}
