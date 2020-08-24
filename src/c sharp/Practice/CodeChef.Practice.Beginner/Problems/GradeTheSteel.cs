using System;
using System.Collections.Generic;
using System.Text;

namespace CodeChef.Practice.Beginner.Problems
{
    //Problme statement : https://www.codechef.com/problems/FLOW014
    //Solution : https://www.codechef.com/viewsolution/37134866 
    static class GradeTheSteel
    {
        public static void GradeTheSteel_Main(string[] args)
        {
            int numberOfTestCases = ReadlineInt();

            var h = 50;
            var c = 0.7;
            var t = 5600;

            while (numberOfTestCases-- > 0)
            {
                var cond1 = false;
                var cond2 = false;
                var cond3 = false;

                var val = ReadlineListDouble();

                for (int i = 0; i < val.Count; i++)
                {
                    switch (i)
                    {
                        case 0:
                            if (val[0] > h) cond1 = true;
                            break;
                        case 1:
                            if (val[1] < c) cond2 = true;
                            break;
                        case 2:
                            if (val[2] > t) cond3 = true;
                            break;
                    }
                }

                if (cond1 && cond2 && cond3)
                    Console.WriteLine(10);
                else
                {
                    if (cond1 && cond2 && !cond3)
                        Console.WriteLine(9);
                    else
                    {
                        if (!cond1 && cond2 && cond3)
                            Console.WriteLine(8);
                        else
                        {
                            if (cond1 && !cond2 && cond3)
                                Console.WriteLine(7);
                            else
                            {
                                if (cond1 || cond2 || cond3)
                                    Console.WriteLine(6);
                                else
                                {
                                    if (!cond1 && !cond2 && !cond3)
                                        Console.WriteLine(5);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static string Readline()
        {
            return Console.ReadLine().Trim();
        }

        private static int ReadlineInt()
        {
            return int.Parse(Readline());
        }

        private static List<int> ReadlineListInt()
        {
            return Readline()
                            .Split(' ')
                            .Select(x => int.Parse(x))
                            .ToList();
        }

        private static List<double> ReadlineListDouble()
        {
            return Readline()
                            .Split(' ')
                            .Select(x => double.Parse(x))
                            .ToList();
        }
    }
}
