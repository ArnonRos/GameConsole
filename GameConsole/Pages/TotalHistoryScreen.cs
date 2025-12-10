using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class TotalHistoryScreen : Base.Screen
    {
        public TotalHistoryScreen() : base("Total History Screen")
        {
        }
        public void Show()
        {
            Console.Clear();
            CenterText("USER GAME HISTORY");
            var history = App.ConsoleGameApp.user.HighScores;
            if (history.Count == 0 || history == null)
            {
                CenterText("No game history available.");
            }
            else
            {
                foreach (var record in history)
                {
                    CenterText($"{record.GameName} - Score: {record.Score} - Date: {record.Date}");
                }
            }
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            var mainMenu = new MainMenu();
            mainMenu.Show();
        }

    }
}
