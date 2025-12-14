using GameConsole.App;
using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class UpdatePassword : Screen
    {
        public UpdatePassword() : base("View User Password")
        {
        }
        public override void Show()
        {
            base.Show();
            CenterText("Enter new password: ");
            string newPassword = Console.ReadLine();
            UserDb.Update(new Models.User(App.ConsoleGameApp.user.Name, App.ConsoleGameApp.user.Username , newPassword));
            CenterText("Press any key to return to the Profile menu...");
            Console.ReadKey();
            Screen next = new MainMenu();
            next.Show();

        }
    }
}
