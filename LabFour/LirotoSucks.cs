using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFour
{
    class LirotoSucks
    {
        public static double factorial(double x)
        {
            double temp = x, fct = 1;
            for (double i = 1; i < temp; temp--)
            {
                fct *= temp;
            }
            Console.WriteLine($"factorial = {fct}");
            return fct;
        }
        public static void Execute()
        {
            /*int a, b, c;
            double discriminant, x1,x2;
            Console.WriteLine("Введите индексы a,b,c для квадратного классического уравнения:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            discriminant = b*b - 4*a*c;
            if (discriminant < 0)
            {
            Console.WriteLine("Дискриминант меньше 0,у данного уравнения корней нет.");
            }
            else if (discriminant == 0)
            {
            x1 = -b / 2 * a;
            Console.WriteLine("Дискриминант равен 0,у данного уравнения один корень.");
            Console.WriteLine($"X = {x1}");
            }
            else {
            x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
            x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("Дискриминант больше 0,у данного уравнения два корня.");
            Console.WriteLine($"X1 = {x1};\tX2 = {x2}");
            }*///1-я задача


            /*//π/4 = 
            double divided_pi = 0; int denominator = 1;
            double counter;
            counter = int.Parse(Console.ReadLine());
            for (int i = 1; i < counter + 1; i++)
            {
                divided_pi += (double)1 / denominator;
                Console.WriteLine($"{i}-я итерация,шаг 1: 1/{denominator} = {divided_pi}");
                denominator += 2;
                Console.WriteLine($"{i}-я итерация,шаг 2: 1/{denominator}");
                divided_pi -= (double)1 / denominator;
                Console.WriteLine($"{i}-я итерация,шаг 3: 1 - 1/{denominator} = {divided_pi}");
                denominator += 2;
            }
            double pi = (double)divided_pi * 4;
            Console.WriteLine(pi);*/ //2 - я задача

            //1,1,2,3,5,8,13,21

            /*int a = 0;
            int b = 1;
            for (; a < 10000; )
            {
                int temp = a;
                a = b;
                b = temp + b;
                if (a > 999 && a < 10000) {
                    Console.Write($"{a} ");
                }
            }*/ //3-я задача

            double cosx = 1, counter = 1, x, q;
            Console.Write("Введите искомый угол(в градусах): ");
            x = double.Parse(Console.ReadLine());
           
            Console.WriteLine($"x = {x}");

            Console.WriteLine("Введите коэффициент точности 0<q<1 в формате 0,qqqqq: ");
            q = double.Parse(Console.ReadLine());
            if (q > 1 || q < 0) Console.WriteLine("Нет,так ничего не работает");
            Console.WriteLine($"q = {q}");
            
            int c = 0;
            for (int i = 2; q < Math.Abs(Math.Pow(x, i) / factorial(i)); i += 2)
            {
                Console.WriteLine($"{c}|{cosx}");
                if (counter % 2 == 1) cosx -= Math.Pow(x, i) / factorial(i);
                else cosx += Math.Pow(x, i) / factorial(i);
                counter++;c++;
            }
            Console.WriteLine(cosx); //4-я задача*/


            /*int N;
            Console.Write("Введите число для разложения ");
            N = int.Parse(Console.ReadLine());

            if (N <= 0)
            {
                Console.Write("N должно быть натуральным числом ");
            }
            else
            {
                for (int x = 0; x < N; x++)
                {
                    for (int y = 0; y < N; y++)
                    {
                        for (int z = 0; z < N; z++)
                        {
                            if (N == Math.Pow(x, 3) + Math.Pow(y, 3) + Math.Pow(z, 3))
                            {
                                Console.Write($"{x},{y},{z} или ");
                            }
                        }
                    }
                }
            }5-я задача*/

            /*Console.Write("Введите возраст от 1 до 100 ");
            int age = int.Parse(Console.ReadLine());
            if (age < 0 || age > 100)
            {
                Console.WriteLine("Введено неправильное значение");
            }
            else {
                if (age % 10 == 1)
                {
                    Console.Write($"{age} год ");
                }
                else if (age % 10 > 1 && age % 10 < 5)
                {
                    Console.Write($"{age} года ");
                }
                else {
                    Console.Write($"{age} лет ");
                }
            } 6-я задача*/

            /*double a, b, c;
            Console.Write("введите стороны треугольника: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if (a < 0 || b < 0 || c < 0)
            {
                Console.WriteLine("Error");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("True");
            }
            else {
                Console.WriteLine("False");
            } 1-я индивидуальная задача*/


            /*for (int i = 100; i < 1000; i++) {
                if (i / 100 == i%10) {
                    Console.WriteLine(i);
                }
            } 2-я индивидальная задача*/
        }
    }
}