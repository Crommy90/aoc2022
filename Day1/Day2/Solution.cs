using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022.Day2
{
    internal class Solution
    {



        public void Run()
        {
            string text = File.ReadAllText("Data/day2_input.txt");
            string[] splitStrings = text.Split("\n");
            List<Strategy> strategies = new List<Strategy>();
            
            foreach (string split in splitStrings)
            {
                Strategy strat = new Strategy(split, StrategyMode.Response);
                strategies.Add(strat);
            }
            int score = strategies.Sum(x => x.GetScore());
            Console.WriteLine($"Day 2 Part 1 solution: {score}");


            List<Strategy> outcomeStrategies = new List<Strategy>();
            foreach (string split in splitStrings)
            {
                Strategy strat = new Strategy(split, StrategyMode.Outcome);
                outcomeStrategies.Add(strat);
            }
            int scoreOutcomes = outcomeStrategies.Sum(x => x.GetScore());
            Console.WriteLine($"Day 2 Part 2 solution: {scoreOutcomes}");
        }
    }
}
