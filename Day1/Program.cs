namespace Day1
{
    internal class Program
    {
        private static List<Calories> _calories = new List<Calories>();

        static void ProcessCalories( string input )
        {
            string[] splitStrings = input.Split("\n");
            Calories calories = new Calories();
            foreach( string split in splitStrings )
            {
                if( split.Trim().Length == 0)
                {
                    _calories.Add( calories );
                    calories = new Calories();
                }
                else
                {
                    calories.CalorieList.Add(Int32.Parse(split));
                }
            }
            if( calories.CalorieList.Count > 0 )
            {
                _calories.Add(calories);
            }

            _calories.Sort(delegate (Calories x, Calories y)
            {
                int xCalories = x.GetTotal();
                int yCalories = y.GetTotal();
                return yCalories - xCalories;
            });

        }

        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText("Data/input.txt");
            ProcessCalories(text);
            int maxCalories = _calories.Max(x => x.GetTotal());
            Console.WriteLine( $"Max Calories: {maxCalories}");
            int topThree = 0;
            foreach (var i in Enumerable.Range(0, 3))
            {
                topThree += _calories[i].GetTotal();
            }
            Console.WriteLine($"Top 3 Calories: {topThree}");

        }
    }
}