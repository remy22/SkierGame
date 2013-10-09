using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    public  class Score
    {
        public static int GameScore { get; set; }
        public static int BestGameScore { get; set; }
        public Score()
        {
        }

        public static void PrintScore()
        {
            Console.WriteLine("Score:{0}", GameScore);
            //return GameScore;
        }

        public static void PrintBestScore()
        {
            Console.WriteLine("Best Score:{0}", BestGameScore);
            if (BestGameScore < GameScore)
            {
                BestGameScore = GameScore;
            }
        }
    }
}
