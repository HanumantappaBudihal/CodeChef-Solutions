using System;
using System.Linq;

namespace CodeChef.Practice.Beginner.Problems
{
    //Problem statement : https://www.codechef.com/problems/CHN15A
    //Solution : https://www.codechef.com/viewsolution/37134625
    static class MutatedMinions
    {
        public static void MutatedMinions_Main(string[] args)
        {
            // Get the number of test cases
            var inputLine = Console.ReadLine().Trim();
            var numberOfTestCases = Convert.ToInt32(inputLine);

            for (int loop = 0; loop < numberOfTestCases; loop++)
            {
                // Get the input
                inputLine = Console.ReadLine().Trim();
                var input = inputLine.Split(' ').Select(Int32.Parse).ToList();
                var N = input[0];
                var K = input[1];
                inputLine = Console.ReadLine().Trim();
                var characteristics = inputLine.Split(' ').Select(Int32.Parse).ToList();

                // Count the number of wolverines
                var wolverines = 0;
                for (int innerLoop = 0; innerLoop < N; innerLoop++)
                {
                    if ((characteristics[innerLoop] + K) % 7 == 0)
                    {
                        wolverines++;
                    }
                }

                Console.WriteLine(wolverines.ToString());
            }
        }
    }
}
