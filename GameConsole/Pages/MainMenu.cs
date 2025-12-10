using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class MainMenu : MenuScreen
    {
        public MainMenu() : base("Main Menu")
        {
            Add(new MenuItem("Register", new RegisterScreen()));
            Add(new MenuItem("Login", new LoginScreen()));
            Add(new MenuItem("Game Menu", new GameMenu()));
            Add(new MenuItem("User Details", new ViewDetails()));
        }
    }
}
