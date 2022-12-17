using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOC2022.Day1
{
    public class Calories
    {
        public List<int> CalorieList { get; } = new List<int>();

        public int GetTotal()
        {
            return CalorieList.Sum();
        }
    }
}
