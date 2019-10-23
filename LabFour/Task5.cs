using System;
using System.Text.RegularExpressions;

namespace LabFour
{
    public class Task5
    {
        internal static void Execute()
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]*\d\d\b");
            Console.WriteLine("Please enter your sentence");
            FindNameWithNumbersUsingRegex(Console.ReadLine(), regex);
        }
        static String findNameWithNumbers(String input) //TODO: THIS
        {
            int startNum = 0;
            String output = "";
            for(int i = 0; i<=input.Length;i++)
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    startNum = i;
                    while (true)
                    {
                        if (input[i] >= 'a' && input[i] <= 'z')
                        {
                            Console.WriteLine("  sdadss1s");
                            break;
                           
                        }
                        else if (char.IsDigit(input[i])&& char.IsDigit(input[i+1]))
                        {
                            Console.WriteLine("  sdads");
                            for(int j = startNum; j <= i;j++)
                            {
                                output += input[i];
                                if (j == i)
                                    output += " ";
                            }
                            break;
                        }
                    }
                }
            }
            return output;
        }
        static void FindNameWithNumbersUsingRegex(String input, Regex regex)
        {
            MatchCollection matches = regex.Matches(input);
            foreach (Match match in matches)
                Console.Write(match.Value+" ");
        }
    }
}
