using System;
using System.Collections.Generic;

namespace LabFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the task: ");
            TaskOneAlt();
        }

        static void TaskOne()
        {
            Console.Write("Please enter your sentence: ");
            String sentence = Console.ReadLine();
            List<Char> chars = new List<char>();
            for(int i =0; i < sentence.Length; i++)
            {
                for(int j = 0; j < chars.Count+1; j++)
                {
                    if (!chars.Contains(sentence[i]))
                    {
                        chars.Add(sentence[i]);
                        Console.Write(chars[chars.Count - 1] + " ");
                        break;
                    }
                }
            }
        }
        static void TaskOneAlt()
        {
            Console.Write("Please enter your sentence: ");
            String sentence = Console.ReadLine();
            List<Char> chars = new List<char>();
            chars.AddRange(sentence);
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < chars.Count + 1; j++)
                {
                    if (chars.Contains(sentence[i]))
                    {
                        chars.Remove(chars[chars.IndexOf(sentence[i])]);
                        break;
                    }
                }
            }
            for (int i = 0; i < chars.Count;i++)
            {
                Console.Write(chars] + " ");
            }
        }
    }
}
