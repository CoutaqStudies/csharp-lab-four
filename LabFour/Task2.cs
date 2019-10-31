
using System;
using System.Text.RegularExpressions;

namespace LabFour
{
    internal class Task2
    {
        internal static void Execute() {
            addNumbers();
        }
        public static void addNumbers()
        {
            Console.WriteLine("Please enter your sentence: ");
            String input = Console.ReadLine();
            //input += ".";
            Regex regex = new Regex(@"(?<=[ ,-.])");
            String[] words = regex.Split(input);
            for (int i = 0; i < words.Length; i++)
            {
                if(i!=words.Length-1) words[i] = words[i].Insert(words[i].Length - 1, $"({i})");
                else words[i] = words[i].Insert(words[i].Length, $"({i})");
            }
               
            foreach (String w in words)Console.Write(w);
        }
    }
}