using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearnExmples
{
    class Program
    {
        static void SayHi()
        {
            Console.WriteLine("Hello");

        }

        static void Print(int z)
        {
            Console.WriteLine(z);
        }

        static void Increment(int x)
        {
            Console.WriteLine(x++);

            Console.WriteLine(++x);

        }

        static int Sum(int a, int b)
        {
            return a + b;
        }


        static int Pow(int x, int y = 2)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;

        }

        static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }


        static void Main(string[] args)
        {

            SayHi();
            Print(25);
            SayHi();
            Increment(3);
            SayHi();
            Increment(2);
            SayHi();
            Console.WriteLine(Sum(1, 2));
            SayHi();
            int c = Sum(2, 3);
            Console.WriteLine(c);
            SayHi();
            Console.WriteLine(Pow(4, 3));
            SayHi();
            Console.WriteLine(Fact(5));
            Console.ReadKey();

        }
    }
}