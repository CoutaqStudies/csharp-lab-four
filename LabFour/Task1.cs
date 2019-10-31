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
                if(Console.ReadLine().ToLower() == "string")
                    RemoveUsingStringFunctions();
                else
                    RemoveUsingACharArray();
            }
            static void RemoveUsingACharArray()
            {
                Console.Write("Please enter your sentence: ");
                String sentence = Console.ReadLine();
                List<Char> chars = new List<char>();
                for(int i = 0;i<sentence.Length;i++)
                {
                    if (chars.Contains(sentence[i]))
                        chars.Remove(sentence[i]);
                    else
                        chars.Add(sentence[i]);
                }
                foreach(Char w in chars)Console.Write(w);
            }
            static void RemoveUsingStringFunctions()
            {
                Console.Write("Please enter your sentence: ");
                String sentence = Console.ReadLine();
                string new_sentence = "";
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (new_sentence.Contains(sentence[i]))
                        new_sentence = new_sentence.Remove(new_sentence.IndexOf(sentence[i]));
                    else
                        new_sentence += sentence[i];
                }
                Console.Write(new_sentence);
            }
    }
}
