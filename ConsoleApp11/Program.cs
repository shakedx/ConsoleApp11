using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите количество минут:");
                int t = int.Parse(Console.ReadLine());
                int n = 1;
                int R;
                do
                {
                    R = n * 2;
                    n++;
                    Console.WriteLine(R);
                }
                while (n != t);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}