using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Models
{
    public class HighScore
    {
        public string GameName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
        public HighScore(string gameName, int score)
        {
            this.GameName = gameName;
            this.Score = score;
            this.Date = DateTime.Now;
        }
    }
}
