using GameConsole.Interfaces;
using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class GameScreen: Base.Screen
    {
        private IGamePlay game;

        public GameScreen(IGamePlay g) : base(g.Name)
        {
            game = g;
        }

        public override void Show()
        {
            base.Show();
            CenterText($"Starting {game.Name}...");
            game.Play();
            HighScore hs = new HighScore(game.Name,game.Score);
            Console.WriteLine("your score is: " + hs.Score);
            App.ConsoleGameApp.user.ChangeHighScore(hs);
            Console.ReadKey();
        }

    }
}
