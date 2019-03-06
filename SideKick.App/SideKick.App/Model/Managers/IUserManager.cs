using SideKick.App.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SideKick.App.Model.Managers
{
    public interface IUserManager
    {
        Task<User> GetUserAsync();
    }
}
