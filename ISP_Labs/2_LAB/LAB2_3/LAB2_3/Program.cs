using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LAB2_3
{
    class Program
    {
        static void Main(string[] args)
        { begin:
            try
            {
                Console.Write("First num: ");
                ulong a = Convert.ToUInt64(Console.ReadLine());
                Console.Write("\nSecond num: ");
                ulong b = Convert.ToUInt64(Console.ReadLine());
                ulong temp;
                if (b < a) {
                    temp = b;
                    b = a;
                    a = temp;
                }
                BigInteger Big=1;
                for (ulong i = a; i <= b; i++) {Big *= i;}
                ulong count=0;
                for (;;) {
                    if (Big % 2 == 0)
                    {
                        count++;
                        Big /= 2;
                    } else {
                        Console.WriteLine($"2 in {count}");
                        break;
                      }
                }

            }
            catch
            {
                Console.WriteLine("There are some problems. Try again!");
                Console.ReadKey();
                Console.Clear();
                goto begin;
            }
                Console.WriteLine("\n-------------------\nExit: press q\nRetry: press any key");
                string q = Console.ReadLine();
                if (q != "q")
                {
                    Console.Clear();
                    goto begin;
                }
            
        }
    }
}
