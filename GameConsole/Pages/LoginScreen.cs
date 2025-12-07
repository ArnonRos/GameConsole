using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    public class LoginScreen : Screen
    {
        public LoginScreen() : base("LOGIN SCREEN")
        {
         
        }

        public override void Show()
        {
            base.Show();
            CenterText("Welcome back");
            CenterText("Enter your username:");
            string username = Console.ReadLine();
            CenterText("Enter your password:");
            string password = Console.ReadLine();
            Models.User us = UserDb.Login(username, password);
            if (us == null)
            {
                CenterText("Invalid username or password. Press any key to return to main menu.");
                Console.ReadKey();
                Screen nexts = new MainMenu();
                nexts.Show();
            }
            CenterText("Login successful! Press any key to continue.");
            Console.ReadKey();
            Screen next = new GameMenu();
            next.Show();
        }
    }
}
