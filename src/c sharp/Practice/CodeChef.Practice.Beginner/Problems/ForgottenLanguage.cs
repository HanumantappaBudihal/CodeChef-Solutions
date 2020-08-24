using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChef.Practice.Beginner.Problems
{
    //Problem statement : https://www.codechef.com/problems/FRGTNLNG
    //Solution : https://www.codechef.com/viewsolution/30020843
    public static class ForgottenLanguage
    {
        public static void ForgottenLanguage_Main(string[] args)
        {
            int numberOfTestCases = Convert.ToInt32(Console.ReadLine());

            while (numberOfTestCases-- > 0)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                int numberOfWords = Convert.ToInt32(inputs[0]);
                int numberOfSentnce = Convert.ToInt32(inputs[1]);
                string[] inputWords = Console.ReadLine().Split(' ');
                List<WordOccurence> words = new List<WordOccurence>();
                WordOccurence wordOccurence;

                foreach (var item in inputWords)
                {
                    wordOccurence = new WordOccurence();
                    wordOccurence.Word = item;
                    wordOccurence.isPresent = false;

                    words.Add(wordOccurence);
                }

                words.ForEach(t => t.isPresent = false);
                while (numberOfSentnce-- > 0)
                {
                    string[] sentence = Console.ReadLine().Split(' ');

                    foreach (var item2 in words)
                    {
                        if (!item2.isPresent)
                        {
                            if (sentence.Contains(item2.Word))
                                item2.isPresent = true;
                        }
                    }
                }

                foreach (var item in words)
                {
                    if (item.isPresent)
                        Console.Write("YES ");
                    else
                        Console.Write("NO ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public class WordOccurence
        {
            public string Word { get; set; }
            public bool isPresent { get; set; }
        }
    }
}
