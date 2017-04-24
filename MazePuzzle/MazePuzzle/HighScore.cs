using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePuzzle
{
    // [Serializable]
    public class HighScore
    {
        public int MazeID { get; set; }
        public string Name;
        public double Time { get; set; }
        // List<HighScore> highscores = new List<HighScore>();

        public HighScore(int mazeid, string name, double time)
        {
            this.MazeID = mazeid;
            this.Name = name;
            this.Time = time;
        }

        /*public void addToHighScores(HighScore newscore)
        {
            highscores.Add(newscore);
        } */

        public override string ToString()
        {
            return this.MazeID + "|" + this.Name + "|" + this.Time;
        }

    }


}
