using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class ViewDetails : Screen
    {
        public ViewDetails() : base("View User Details")
        {
        }
        public override void Show()
        {
            base.Show();
            CenterText($"Username: {App.ConsoleGameApp.user.Username}");
            CenterText($"Email: {App.ConsoleGameApp.user.Password}");;
            Console.ReadKey();
            CenterText("Press any key to return to the main menu...");
            Screen next = new MainMenu();
            next.Show();
        }
    }
}
