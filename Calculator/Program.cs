using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int sum = Calcolo.Sum(a, b);


            //somma
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
        }
    }
}
