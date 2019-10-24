using System;
namespace LabFour
{
    public class Doonil
    {
        public static void Exec()
        {
            try
            {
                Console.Clear();
                Console.Write("Write x: ");
                float x = Single.Parse(Console.ReadLine());
                Console.Write("Write number of terms Q: ");
                uint q = UInt32.Parse(Console.ReadLine());
                double cos_x = 0.0;
                int degree_x_and_factorial = 0;
                double factorial = 1.0;
                // uint metre_of_terms = UInt32.MinValue;
                for (int i = 0; i < q; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = degree_x_and_factorial; j > 1; j--)
                        {
                            factorial *= j;
                        }
                        cos_x += Math.Pow(x, degree_x_and_factorial) / factorial;
                        degree_x_and_factorial += 2;
                        factorial = 1.0;
                    }
                    else
                    {
                        for (int j = degree_x_and_factorial; j > 0; j--)
                        {
                            factorial *= j;
                        }
                        cos_x -= Math.Pow(x, degree_x_and_factorial) / factorial;
                        degree_x_and_factorial += 2;
                        factorial = 1.0;
                    }/*
                    if (Math.Abs(term) < q)
                    {
                        Console.Write($"Number of successful terms: {metre_of_terms}");
                        break;
                    }
                    else 
                    {
                        metre_of_terms++;
                    } */
                }
                Console.WriteLine($"\nCos(x) = {cos_x}");
                Console.ReadKey();
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Error.. Try again");
                Console.ReadKey();
                Program.Main(args);
            }
        }
    }
}
