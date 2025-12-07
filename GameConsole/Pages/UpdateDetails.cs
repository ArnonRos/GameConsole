using GameConsole.Base;
using GameConsole.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class UpdateDetails : Screen
    {
        public UpdateDetails() : base("Update User Details")
        {
        }
        public override void Show()
        {
            base.Show();
            CenterText("Enter new username: ");
            string newUsername = Console.ReadLine();
            CenterText("Enter new password: ");
            string newPassword = Console.ReadLine();
            UserDb.Update(new Models.User("", newUsername, newPassword));
            CenterText("Press any key to return to the main menu...");
            Console.ReadKey();
            Screen next = new MainMenu();
            next.Show();
        }
    }
}
