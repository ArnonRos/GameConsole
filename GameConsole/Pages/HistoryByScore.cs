using GameConsole.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class HistoryByScore : Base.Screen
    {
        public HistoryByScore() : base("History By Score")
        {
        }
        public override void Show()
        {
            base.Show();
            var scores = App.ConsoleGameApp.user.HighScores;
            scores.OrderBy(scores => scores.Score).ToList();
            if (scores.Count == 0 || scores == null)
            {
                CenterText("No high scores available.");
            }
            else
            {
                CenterText("High Scores Sorted by Score:");
                foreach (var score in scores)
                {
                    CenterText($"Game: {score.GameName}, Score: {score.Score}");
                }
            }
            CenterText("Press any key to return to the History Menu...");
            Console.ReadKey();
            MenuScreen   next = new HistoryMenu();
            next.Show();
        }
    }
}
