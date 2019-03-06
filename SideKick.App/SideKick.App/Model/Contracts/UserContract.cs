using System;
using System.Collections.Generic;
using System.Text;

namespace SideKick.App.Model.Contracts
{
    public class UserContract
    {
        public string Avatar { get; set; }
        public string Name { get; set; }
        public DateTime CurrentTimeUtc { get; set; }
    }
}
