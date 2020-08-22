using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef.Practice.Beginner.Problems
{
    //Problem statement : https://www.codechef.com/problems/FLOW001
    //My solution :  https://www.codechef.com/viewsolution/37060168
    static class AddTwoNumbers
    {
        public static void AddTwoNumbers_Main()
        {
            int numberOfInputs = Convert.ToInt32(Console.ReadLine());
            string[] inputNumbers;
            int number1, number2;

            while (numberOfInputs-- > 0)
            {
                inputNumbers = Console.ReadLine().Split(' ');
                number1 = Convert.ToInt32(inputNumbers[0]);
                number2 = Convert.ToInt32(inputNumbers[1]);
                Console.WriteLine((number1 + number2).ToString());
            }
        }
    }
}
