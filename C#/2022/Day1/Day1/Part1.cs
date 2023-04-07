using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Part1
    {
        public static int Solve(string input)
        {
            SortedSet<int> totalCaloriesPerElf = new SortedSet<int>();
            string[] elfCalories = input.Split(new string[] { "\r\n\r\n", "\n\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string elfCalorie in elfCalories)
            {
                string [] lines = elfCalorie.Split('\n');

                int sum = 0;
                foreach (string line in lines)
                {
                    int calorie = int.Parse(line);
                    sum += calorie;
                }
                totalCaloriesPerElf.Add(sum);
            }

            return totalCaloriesPerElf.Max;
        }
    }
}
