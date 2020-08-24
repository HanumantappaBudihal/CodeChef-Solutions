using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef.Practice.Beginner.Problems
{
    //Problem statement : https://www.codechef.com/problems/RAINBOWA
    //Solution : https://www.codechef.com/viewsolution/37134728
    static class ChefAndRainbowArray
    {
        public static void ChefAndRainbowArray_Main()
        {
            int testCount = int.Parse(Console.ReadLine());
            for (int t = 0; t < testCount; t++)
            {
                int arrayLength = int.Parse(Console.ReadLine());
                string[] rawInputItems = Console.ReadLine().Split(' ');
                int[] values = new int[arrayLength];
                for (int i = 0; i < arrayLength; i++)
                {
                    values[i] = int.Parse(rawInputItems[i]);
                }

                Console.WriteLine(IsRainbow(arrayLength, values) ? "yes" : "no");
            }
        }

        private static bool IsRainbow(int arrayLength, int[] values)
        {
            int forwardIndex = arrayLength / 2;
            if (values[0] != 1 || values[arrayLength - 1] != 1 || values[forwardIndex] != 7)
            {
                return false;
            }

            int backwardIndex = forwardIndex;
            if ((arrayLength & 1) == 0)
            {
                backwardIndex--;
            }
            int currentValue = values[forwardIndex];
            for (int i = 0; i <= backwardIndex; i++)
            {
                if (values[backwardIndex - i] != values[forwardIndex + i])
                {
                    return false;
                }
                if (values[backwardIndex - i] != currentValue && values[backwardIndex - i] != currentValue - 1)
                {
                    return false;
                }
                currentValue = values[backwardIndex - i];
            }
            return true;
        }
    }
}
