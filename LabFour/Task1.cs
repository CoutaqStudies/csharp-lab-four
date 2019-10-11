using System;
using System.Collections.Generic;

namespace LabFour
{
    public class Task1
    {
        public Task1()
        {
        }
            public static void Execute(){
                Console.WriteLine("Using char array or string? ");
                if(Console.ReadLine() == "string")
                {
                    RemoveUsingStringFunctions();
                }
                else
                {
                    RemoveUsingACharArray();
                }
            }
            static void RemoveUsingACharArray()
            {
                Console.Write("Please enter your sentence: ");
                String sentence = Console.ReadLine();
                List<Char> chars = new List<char>();
                foreach (char i in sentence)
                {
                    if (chars.Contains(i))
                    {
                        chars.Remove(i);
                    }
                    else
                    {
                        chars.Add(i);
                    }
                }
                foreach (char i in chars)
                {
                    Console.Write(i + " ");
                }
            }
            static void RemoveUsingStringFunctions()
            {
                Console.Write("Please enter your sentence: ");
                String sentence = Console.ReadLine();
                string new_sentence = "";
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (new_sentence.Contains(sentence[i]))
                    {
                        new_sentence = new_sentence.Remove(new_sentence.IndexOf(sentence[i]));
                    }
                    else
                    {
                        new_sentence += sentence[i];
                    }
                }
                Console.Write(new_sentence);
            }
    }
}
