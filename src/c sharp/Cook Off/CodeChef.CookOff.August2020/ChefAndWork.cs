using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CodeChef.CookOff.August2020
{
    //Problem statement : https://www.codechef.com/COOK121B/problems/CHEFNWRK
    //Solution : https://www.codechef.com/viewsolution/37087288
    static class ChefAndWork
    {
        public static void ChefAndWork_Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
            while (numberOfTestCases-- > 0)
            {
                string[] input = Console.ReadLine().Split(' ');
                int numberOfBags = Convert.ToInt32(input[0]);
                int maxWeight = Convert.ToInt32(input[1]);
                string[] input2 = Console.ReadLine().Split(' ');
                int[] weights = Array.ConvertAll(input2, s => int.Parse(s));

                int tripCount = 0;
                int weightOnTrip = 0;

                foreach (var item in weights)
                {
                    weightOnTrip = weightOnTrip + item;
                    if (weightOnTrip < maxWeight)
                        continue;

                    if (weightOnTrip >= maxWeight)
                    {
                        if (weightOnTrip == maxWeight)
                        {
                            tripCount++;
                            weightOnTrip = 0;
                            continue;
                        }

                        if (item > maxWeight)
                        {
                            tripCount = -1;
                            break;
                        }

                        if ((weightOnTrip - item) <= maxWeight)
                        {
                            tripCount++;
                            weightOnTrip = item;
                        }
                    }
                }

                if (weightOnTrip > 0 && weightOnTrip <= maxWeight)
                    tripCount++;

                Console.WriteLine(tripCount);
            }
            Console.ReadLine();
        }
    }
}
