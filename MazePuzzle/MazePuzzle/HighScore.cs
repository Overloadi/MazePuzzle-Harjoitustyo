using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazePuzzle
{
    /// <summary>
    /// Class, where the highscores are saved as objects
    /// </summary>
    public class HighScore
    {
        public string MazeName { get; set; }
        public string Name;
        public double Time { get; set; }

        /// <summary>
        /// Create the object
        /// </summary>
        /// <param name="mazename">Name of the maze</param>
        /// <param name="name">Player's name</param>
        /// <param name="time">Player's time</param>
        public HighScore(string mazename, string name, double time)
        {
            this.MazeName = mazename;
            this.Name = name;
            this.Time = time;
        }

        /// <summary>
        /// Used when highscores are saved into the highscores file
        /// </summary>
        /// <returns>Highscore object data separated with '|'</returns>
        public override string ToString()
        {
            return this.MazeName + "|" + this.Name + "|" + this.Time;
        }

    }


}
