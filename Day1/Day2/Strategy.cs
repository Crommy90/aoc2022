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

    enum RoundOutcome
    {
        Lose,
        Draw,
        Win
    }

    enum StrategyMode
    {
        Response,
        Outcome
    }

    class RPSDict
    {
        public static Dictionary<char, RPS> Dict = new Dictionary<char, RPS>
        {
            { 'A', RPS.Rock },
            { 'B', RPS.Paper },
            { 'C', RPS.Scissors },
            { 'X', RPS.Rock },
            { 'Y', RPS.Paper },
            { 'Z', RPS.Scissors },
        };
        
        public static Dictionary<char, RoundOutcome> OutcomeDict = new Dictionary<char, RoundOutcome>
        {
            { 'X', RoundOutcome.Lose },
            { 'Y', RoundOutcome.Draw },
            { 'Z', RoundOutcome.Win },
        };
    };


    internal class Strategy
    {

        private RPS _opponent;
        private RPS _response;


        public Strategy(string line, StrategyMode mode)
        {

            _opponent = RPSDict.Dict[line[0]];
            if (mode == StrategyMode.Response)
            {
                _response = RPSDict.Dict[line[2]];
            }
            else
            {
                RoundOutcome outcome = RPSDict.OutcomeDict[line[2]];
                switch (outcome)
                {
                    case RoundOutcome.Lose:
                        _response = (RPS)((((int)_opponent) - 1) % 3);
                        if ((int)_response == 0)
                        {
                            _response += 3;
                        }
                        break;
                    case RoundOutcome.Draw:
                        _response = _opponent;
                        break;
                    case RoundOutcome.Win:
                        _response = (RPS) ((((int)_opponent) + 1) % 4);
                        if ((int)_response == 0)
                        {
                            ++_response;
                        }
                        break;
                }
                
            }
        }

        public int GetScore()
        {
            int score = (int) _response;
            if( _response == _opponent )
            {
                score+=3;
            }
            if( ((int) _response - 1) == (int) _opponent
                || (_response == RPS.Rock && _opponent == RPS.Scissors))
            {
                score += 6;
            }
            return score;
        }
    }

}
