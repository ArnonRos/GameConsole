using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class ProfileMenu : MenuScreen
    {
        public ProfileMenu() : base("Profile Menu")
        {
            Add(new MenuItem("View Details", new ViewDetails()));
            Add(new MenuItem("Update Password", new UpdatePassword()));
            Add(new MenuItem("Update Username", new UpdateUsername()));
        }

    }
}
