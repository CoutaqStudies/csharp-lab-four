using System;
using System.Collections.Generic;

namespace LabFour
{
    public class Task4
    {
        internal static void Execute()
        {
            findDotComAlt();
        }
        internal static void findDotCom()
        {
            Console.WriteLine("Enter your Strings: ");
            String[] input = new String[7];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }
            Char[] splitter = { ' ', ',', '.' };
            Console.WriteLine();
            foreach (String i in input)
            {
                String[] words = i.Split(splitter);
                foreach (String w in words)
                {
                    if (w.ToUpper().Equals("COM"))
                    {
                        Console.WriteLine(i);
                        continue;
                    }
                }
            }
        }
        internal static void findDotComAlt()
        {
            Console.WriteLine("Enter your Strings: ");
            String[] input = new String[1 ];
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = Console.ReadLine();
            }
            Char[] splitter = { ' ', ',', '.' };
            Console.WriteLine();
            foreach (String i in input)
            {
                List<String> words = new List<String>();
                for(int j = 0; j<i.Length;j++)
                {
                    if (words.Count==0)
                    {
                        if(i[j]==' ' || i[j] == '.' || i[j] == ',')
                        {
                            String word = "";
                            for(int k = 0; k < j; j++)
                            {
                                word += i[k];
                            }
                            words.Add(word);
                        }
                    }
                    else
                    {
                        if (i[j] == ' ' || i[j] == '.' || i[j] == ',')
                        {
                            String word = "";
                            for (int k = 0; k < j; j++)
                            {
                                word += i[k];
                            }
                            words.Add(word);
                            Console.WriteLine("adsd");
                        }

                    }
                }
                foreach(String word in words)
                {
                    Console.WriteLine(word);
                }
            }


        }
    }
}
