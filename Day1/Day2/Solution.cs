using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022.Day2
{
    internal class Solution
    {

        private List<Strategy> _strategies = new List<Strategy>();

        public void Run()
        {
            string text = File.ReadAllText("Data/day2_input.txt");
            string[] splitStrings = text.Split("\n");
            
            foreach (string split in splitStrings)
            {
                Strategy strat = new Strategy(split);
                _strategies.Add(strat);
            }
            int score = _strategies.Sum(x => x.GetScore());
            Console.WriteLine($"Day 2 solution: {score}");
        }
    }
}
