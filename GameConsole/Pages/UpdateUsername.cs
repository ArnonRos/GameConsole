using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class UpdateUsername : Screen
    {
        public UpdateUsername() : base("Update User Username")
        {
        }
        public override void Show()
        {
            base.Show();
            CenterText("Enter new Username: ");
            string newUsername = Console.ReadLine();
            UserDb.Update(new Models.User(App.ConsoleGameApp.user.Name, newUsername, App.ConsoleGameApp.user.Password));
            CenterText("Press any key to return to the Profile menu...");
            Console.ReadKey();
            Screen next = new ProfileMenu();
            next.Show();

        }
    }
}
