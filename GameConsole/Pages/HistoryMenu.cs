using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Pages
{
    internal class HistoryMenu : Base.MenuScreen
    {
        public HistoryMenu() : base("HISTORY MENU")
        {
            Add("View Total History games", new TotalHistoryScreen());
            Add("View Game History by game name", new HistoryByName());
            Add("View Game History by game score", new HistoryByScore());
            Add("view the last played game", new LastGameScreen());

        }
    }
}
