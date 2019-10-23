
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
            String splitters = "(-)( )(,)";
            String[] words = Regex.Split(input, splitters);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Insert(words[i].Length, $"({i})");
            }
            foreach (String w in words)
                Console.Write($"{w} ");
        }
    }
}