using System;

namespace Module1
{
    class changeVariables
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int temp;
            Console.WriteLine("Начальные значения a и b:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Результат работы функции:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }
}
