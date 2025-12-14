using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class RegisterScreen : Screen
    {
        public RegisterScreen() : base("REGISTER PAGE")
        {
        }

        public override void Show()
        {
            base.Show();
            CenterText("Enter Your name:");
            string name = Console.ReadLine();
            CenterText("enter your username:");
            string username = Console.ReadLine();
            CenterText("enter your password:");
            string password = Console.ReadLine();
            UserDb.RegisterUser(name, username, password);
            Console.ReadKey();
            Screen next = new MainMenu();
            next.Show();
        }
    }
}
