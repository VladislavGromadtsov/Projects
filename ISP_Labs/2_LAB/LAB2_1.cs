using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_1
{
    class Program
    {
        static void Main(string[] args)
        {
           begin: Console.Write("Your sentence: ");
            string str = Console.ReadLine();
            string[] s = str.Split(' ');
            int k = s.Length;
            Console.WriteLine($"{k}");
            str = str.Remove(0);
            int b;
            for (int i = k-1; i >=0; i--) {
                if (i == k - 1){
                    b = s[i].IndexOf('.');
                    if (b > 0){
                        s[i] = s[i].Replace(".", "");
                        s[0] += ".";
                    }
                    b = s[i].IndexOf('?');
                    if (b > 0)
                    {
                        s[i] = s[i].Replace("?", "");
                        s[0] += "?";
                    }
                    b = s[i].IndexOf('!');
                    if (b > 0)
                    {
                        s[i] = s[i].Replace("!", "");
                        s[0] += "!";
                    }
                    
                }
                b = s[i].IndexOf(',');
                if (b > 0) {
                    s[i]=s[i].Replace(",", "");
                    str += ", " + s[i];
                } else {
                    str += s[i] + " ";
                }

            }
            
            str = str.Replace(" ,", ",");


            Console.WriteLine($"\n\n{str}");
            

            Console.WriteLine("\n-------------------\nExit: press q\nRetry: press any key");
            string q=Console.ReadLine();
            if (q != "q") {
                Console.Clear();
                goto begin;
            }

        }
    }
}
