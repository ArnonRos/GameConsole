using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class HistoryByName : Base.Screen
    {
        public HistoryByName() : base("View History By Name")
        {
        }
        public override void Show()
        {
            Console.Clear();
            CenterText("USER GAME HISTORY BY NAME");
            var history = App.ConsoleGameApp.user.HighScores;
            history.OrderBy(h => h.GameName).ToList();
            if (history.Count == 0 || history == null)
            {
                CenterText("No game history available.");
            }
            else
            {
                CenterText("High Scores Sorted by Name:");
                foreach (var record in history)
                {
                    CenterText($"{record.GameName} - Score: {record.Score} - Date: {record.Date}");
                }
            }
            Console.WriteLine("Press any key to return to the main menu...");
            Console.ReadKey();
            MenuScreen mainMenu = new HistoryMenu();
            mainMenu.Show();


        }
    }
}
