using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1_1
{
    class Program
    {
        static void Main(string[] args)
        {
        begin:
            try
            {
                Console.Write("Angle in degrees: ");
                double angle = Convert.ToDouble(Console.ReadLine()) * (Math.PI / 180);
                Console.Write("Speed at start in kph: ");
                double speed = Convert.ToDouble(Console.ReadLine());

                double h = Math.Round((Math.Pow(speed, 2) * Math.Pow(Math.Sin(angle), 2)) / (2 * 9.8));
                double l = Math.Round((Math.Pow(speed, 2) * Math.Sin(angle * 2)) / 9.8);

                //Console.WriteLine($"{angle}  {speed}  {h}  {l}");
                Console.WriteLine("Hight: {0} m\nLenght: {1} m", h, l);
            }
            catch {
                Console.WriteLine("\nThere are some problems. Try again!");
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
