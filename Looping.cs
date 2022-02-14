using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Looping.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.WriteLine("*********For Loop********");
            Console.WriteLine("Enter any Number");
             num = Convert.ToInt32(Console.ReadLine());
            for ( i = 1; i <= num; i++)
            {
                Console.WriteLine("This For is created by Anjali");
            }

            Console.WriteLine("*********While Loop*********");
            Console.WriteLine("Enter any number");
            i = Convert.ToInt32(Console.ReadLine());
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }

            Console.WriteLine("*********Do While Loop*********");
            Console.WriteLine("Enter any number");
            i = Convert.ToInt32(Console.ReadLine());
            do
            {
                i++;
                Console.WriteLine(i);
            } while (i < 10);

            Console.ReadLine();
        }
    }
}
