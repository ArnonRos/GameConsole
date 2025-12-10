using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class PostLoginMenu : MenuScreen
    {
        public PostLoginMenu() : base("Post Login Menu")
        {
            Add(new MenuItem("View Games", new GameMenu()));
            Add(new MenuItem("View Profile Menu", new ProfileMenu()));


        }
    }
}
