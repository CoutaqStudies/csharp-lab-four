using System;
using System.Text.RegularExpressions;

namespace LabFour
{
    public class Task6
    {
       public static void Execute()
        {
            String input = Console.ReadLine();
            Regex regex = new Regex(@"\d*\s*[+]\s*\d*\s*[=]\s*\d*");
            if (regex.IsMatch(input))
            {
                string pattern = @"\s\D";
                string[] digits = Regex.Split(input, pattern);
                int[] nums = new int[3];
                for (int i = 0; i < 3; i++)
                    nums[i] = int.Parse(digits[i]);
                Console.WriteLine($"Term 1: {nums[0]}");
                Console.WriteLine($"Term 2: {nums[1]}");
                Console.WriteLine($"Sum: {nums[2]}");
            }
            else
            {
                Console.WriteLine("The input does not match the specified type (TERM1 + TERM2 = SUM)");
                Execute();
            }
        }
    }
} 
