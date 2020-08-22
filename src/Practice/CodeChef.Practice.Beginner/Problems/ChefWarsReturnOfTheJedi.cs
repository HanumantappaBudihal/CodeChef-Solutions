using System;

namespace CodeChef.Practice.Beginner.Problems
{
    //Problem statement : https://www.codechef.com/problems/CHEFWARS
    //My solution : https://www.codechef.com/viewsolution/37060205
    static class ChefWarsReturnOfTheJedi
    {
        public static void ChefWarsReturnOfTheJedi_Main()
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (numberOfTestCases-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int health = Convert.ToInt32(input[0]);
                int power = Convert.ToInt32(input[1]);

                while (power > 0 && health > 0)
                {
                    health = health - power;
                    power = power / 2;
                }

                if (power >= health)
                    Console.WriteLine("1");
                else
                    Console.WriteLine("0");
            }

            Console.ReadLine();
        }
    }
}
