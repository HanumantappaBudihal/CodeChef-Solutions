using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef.Practice.Beginner.Problems
{
    //Problem statement : https://www.codechef.com/problems/HS08TEST
    //My solution :  https://www.codechef.com/viewsolution/37060099
    static class ATM
    {
        public static void ATM_Main()
        {
            //Read input
            string[] inputStrings = Console.ReadLine().Split(' ');

            //Divide the input values
            decimal withDrawAmount = Convert.ToDecimal(inputStrings[0]);
            decimal totalAmount = Convert.ToDecimal(inputStrings[1]);

            //Computation
            if (totalAmount >= withDrawAmount + 0.5m && withDrawAmount % 5 == 0)
                Console.WriteLine(totalAmount - withDrawAmount - 0.5m);
            else
                Console.WriteLine(totalAmount);

            Console.ReadLine();
        }
    }
}
