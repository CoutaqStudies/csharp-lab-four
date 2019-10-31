
using System;
using System.Text.RegularExpressions;

namespace LabFour
{
    internal class Task2
    {
        internal static void Execute() {
            addNumbersButInAWeirdWay();
        }
        public static void addNumbers()
        {
            Console.WriteLine("Please enter your sentence: ");
            String input = Console.ReadLine();
            Regex regex = new Regex(@"(?<=[ ,-.])");
            String[] words = regex.Split(input);
            for (int i = 0; i < words.Length; i++)
            {
                if(i!=words.Length-1) words[i] = words[i].Insert(words[i].Length - 1, $"({i})");
                else words[i] = words[i].Insert(words[i].Length, $"({i})");
            }
               
            foreach (String w in words)Console.Write(w);
        }
        public static void addNumbersButInAWeirdWay()
        {
            Console.WriteLine("Please enter your sentence: ");
            String input = Console.ReadLine();
            String words = "";
            String split = " ,-";
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]==split[0] || input[i] == split[1] || input[i] == split[2])
                {
                    for(int j =words.Length; j < i; j++)
                    {
                        words+=input[j];
                    }
                }
            }

            foreach (char w in words) Console.Write(w);
        }
    }
}