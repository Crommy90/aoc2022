using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022.Day2
{
    enum RPS
    {
        Rock = 1,
        Paper = 2,
        Scissors = 3
    }

    internal class Strategy
    {

        public RPS Opponent { get; set; }
        public RPS Response { get; set; }

        

        public Strategy( string line )
        {
            Dictionary<char, RPS> rpsDict = new Dictionary<char, RPS>
            {
                { 'A', RPS.Rock },
                { 'B', RPS.Paper },
                { 'C', RPS.Scissors },
                { 'X', RPS.Rock },
                { 'Y', RPS.Paper },
                { 'Z', RPS.Scissors },
            };
            Opponent = rpsDict[line[0]];
            Response = rpsDict[line[2]];
        }

        public int GetScore()
        {
            int score = (int) Response;
            if( Response == Opponent )
            {
                score+=3;
            }
            if( ((int) Response - 1) == (int) Opponent
                || (Response == RPS.Rock && Opponent == RPS.Scissors))
            {
                score += 6;
            }
            return score;
        }
    }
}
