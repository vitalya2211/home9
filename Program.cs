using System;

namespace home9
{
    class Program
    {
        static void Main(string[] args)
        {/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в
          промежутке от M до N.
            M = 1; N = 5. -> ""1, 2, 3, 4, 5""
            M = 4; N = 8. -> ""4, 6, 7, 8""
          Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
            элементов в промежутке от M до N.
            M = 1; N = 15 -> 120
            M = 4; N = 8. -> 30
          Напишите программу вычисления функции Аккермана с помощью рекурсии.   
            Даны два неотрицательных числа m и n.
            m = 2, n = 3 -> A(m,n) = 29*/
            int FooAcc(int a,int b)
            {
                if (a == 0)
                {
                    return b + 1;
                } 
                else if (b == 0 && a > 0)
                {
                    return FooAcc(a - 1, 1);
                } 
                else
                {
                    return FooAcc(a - 1, FooAcc(a, b - 1));
                }
            }

            int start, end,sum=0;
            Console.Write("программа выводит всенатуральные числа в промежутке от М до N\n" +
                "введите начало числового промежутка: ");
            start = int.Parse(Console.ReadLine());
            Console.Write("введите конец числового промежутка:");
            end = Convert.ToInt32(Console.ReadLine());
            if (start < end)
            {
                for (; start <= end; start++)
                    Console.Write(start + "\t");
            }
            else Console.WriteLine("число М меньше N");
            Console.Write("программа находит сумму натуральных чисел от М до N\n" +
                "введите начало отсчета: ");
            int.TryParse(Console.ReadLine() ,out start);
            Console.Write("введите конец отсчета: ");
            end = Convert.ToInt32(Console.ReadLine());
            for (; start <= end; start++)
                sum += start;
            Console.WriteLine("сумма чисел = " + sum);
            Console.Write("вычисление функци Аккермана \n" +
                "введите два не отрицательных числа :");
            Console.WriteLine("первое: ");
            start = int.Parse(Console.ReadLine());
            Console.WriteLine("второе: ");
            end = int.Parse(Console.ReadLine());
            Console.WriteLine( FooAcc(start, end));
            Console.ReadKey();

        }
    }
}
