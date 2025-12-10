using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class LastGameScreen : Screen
    {
        public LastGameScreen() : base("Last Game Screen")
        {
        }
        public override void Show()
        {
            base.Show();
            var scores = App.ConsoleGameApp.user.HighScores;
             var first = scores.OrderByDescending(score => score.Date).ToList().FirstOrDefault();
            if (scores.Count == 0 || scores.Count == null)
            {
                CenterText("No high scores available.");
            }
            else
            {
                CenterText("LAST GAME SCORES:");
                CenterText($"Game: {first.GameName}, Score: {first.Score}, Date: {first.Date}");
            }
            CenterText("Press any key to return to the History Menu...");
            Console.ReadKey();
            MenuScreen next = new HistoryMenu();
            next.Show();
        }

    }
}
