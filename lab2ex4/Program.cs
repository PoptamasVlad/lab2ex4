using System;

namespace lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care va determina daca un numar este sau nu
            palindrom. */
            int n = int.Parse(Console.ReadLine());
            int p = n, x = 0;
            while(n != 0)
            {
                x = x * 10;
                x = x + n % 10;
                n = n / 10;
            }
            if(x == p)
            {
                Console.WriteLine("Este palindrom");
            }
            else
            {
                Console.WriteLine("Nu este palindrom");
            }    
        }
    }
}
