using System;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopsDop();
        }
        static void Loops2()
        {
            int a;
            int b;
            Console.WriteLine("a<b");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = a; i<=b; i++)
            {
                sum += i;
                if (i % 2 != 0) Console.WriteLine(i);
            }

            Console.WriteLine($"sum = {sum}");
        }

        static void Loops3()
        {
            for (int i=0; i<=20; i++)
            {
                for (int j=0; j<=30; j++)
                {
                   if (i == 0 || i == 20)Console.Write("*");

                   else if (j == 0 || j == 30) Console.Write("*");
    
                   else Console.Write(" ");
                }

                Console.Write("\n");     
            }

            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    if (j==0 || j==i || i==20) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }

            for (int i = 0; i <= 15; i++)
            {
                for (int j = 0; j <= 30; j++)
                {
                    if (j == 15 + i || j == 15 - i || i==15) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }

            for (int i = 0; i <= 15; i++)
            {
                for (int j = 0; j <= 30; j++)
                {
                    if (j == 15 + i || j == 15 - i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }

            for (int i = 15; i >= 0; i--)
            {
                for (int j = 0; j <= 30; j++)
                {
                    if (j == 15 + i || j == 15 - i) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
            }
        }

        static void Loops4()
        {
            Console.Write("Enter points for delivery ");
            int deliveryPoints = int.Parse(Console.ReadLine());
            
            if (deliveryPoints<=0)
                Console.WriteLine("number of route 0");

            else
            {
                double numberOfRoute = 1;
                int cnt = 1;
                do
                {
                    numberOfRoute *= cnt;
                    cnt++;
                }
                while (cnt <= deliveryPoints);
                Console.WriteLine($"number of route {numberOfRoute}");
            }
        }

        static void LoopsDop()
        {
            int h, w;

            Console.Write("h = ");
            h = int.Parse(Console.ReadLine());

            Console.Write("w = ");
            w = int.Parse(Console.ReadLine());

            for (int i=0; i<h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
