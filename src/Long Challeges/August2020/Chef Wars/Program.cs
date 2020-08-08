using System;

namespace Chef_Wars
{
    /// <summary>
    /// Problem statement : https://www.codechef.com/AUG20B/submit/CHEFWARS
    /// </summary>
    class Program
    {
        static void Main(string[] args)
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
