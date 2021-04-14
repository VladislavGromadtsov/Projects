using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_2
{
    class Program
    {
        static void my(string date) {
            int len = date.Length;
            char[] buf = date.ToCharArray();
            int count = 0;
            char a;
            Console.WriteLine();

            for (int j = 48; j < 58; j++)
            {
                count = 0;
                for (int i = 0; i < len; i++)
                {
                    if (buf[i] == j) count++;

                }
                a = Convert.ToChar(j);
                Console.WriteLine($"{a} -  {count}");
            }
            
        }


        static void Main(string[] args)
        {
          begin:  DateTime now = DateTime.Now;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write($"{now}");
            string date = Convert.ToString(DateTime.Now);
            my(date);
            date = now.ToString("O");
            Console.WriteLine($"\n{date}");
            my(date);

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
