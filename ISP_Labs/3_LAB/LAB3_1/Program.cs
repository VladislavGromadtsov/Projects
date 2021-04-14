using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_1
{
    class TS {
        private string Name;
        private int Year;
        private string Color;
        private int Mass;
        private int Power;

        public string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int year
        {
            get
            {
                return Year;
            }
            set
            {
                if (value > 1900)
                    Year = value;
                else Console.WriteLine("Year can be only > 1900");
            }
        }
        public string color
        {
            get
            {
                return Color;
            }
            set
            {
                Color = value;
            }
        }
        public int mass
        {
            get
            {
                return Mass;
            }
            set
            {
                if (value > 0)
                    Mass = value;
                else Console.WriteLine("Mass can be only >0 ");

            }
        }
        public int power
        {
            get
            {
                return Power;
            }
            set
            {
                if (value > 0)
                    Power = value;
                else Console.WriteLine("Power can be only >0 ");
            }
        }

        public void Printt() {
            Console.Write("\nName: {0}", name);
            Console.Write("\tYear: {0}", year);
            Console.Write("\tColor: {0}", color);
            Console.Write("\tMass: {0}", mass);
            Console.Write("\tPower: {0}\n", power);
            // Console.Write(Fuel());

        }
        public TS(string BufName, string BufColor, int BufYear, int BufMass, int BufPower) {
            Name = BufName;
            Year = BufYear;
            Color = BufColor;
            Mass = BufMass;
            Power = BufPower;
        }

        public double Fuel() {
            double itog;
            if (Mass <= 1500) {
                if (Power <= 150)
                {
                    itog = (Convert.ToDouble(Mass) / Convert.ToDouble(Power));
                }
                else {
                    itog = (Convert.ToDouble(Mass) / Convert.ToDouble(Power)) * 2.5;
                }
            } else {
                if (Power <= 150)
                {
                    itog = (Convert.ToDouble(Mass) / Convert.ToDouble(Power)) * 1.5;
                }
                else
                {
                    itog = (Convert.ToDouble(Mass) / Convert.ToDouble(Power)) * 3.0;
                }
            }
            return (Math.Round(itog, 2));
        }

        public double Fuel(int count)
        {
            double itog;
            if (Mass <= 1500)
            {
                if (Power <= 150)
                {
                    itog = (Convert.ToDouble(Mass) / Convert.ToDouble(Power + (count * 70.0)));
                }
                else
                {
                    itog = (Convert.ToDouble(Mass) / Convert.ToDouble(Power + (count * 70.0))) * 2.5;
                }
            }
            else
            {
                if (Power <= 150)
                {
                    itog = (Convert.ToDouble(Mass) / Convert.ToDouble(Power + (count * 70.0))) * 1.5;
                }
                else
                {
                    itog = (Convert.ToDouble(Mass) / Convert.ToDouble(Power + (count * 70.0))) * 3.0;
                }
            }
            return (Math.Round(itog, 2));
        }
        public static void Sort(TS[] Avtomobile)
        {
            TS temp;
            for (int i = 0; i < Avtomobile.Length - 1; i++)
            {
                for (int j = 0; j < Avtomobile.Length - i - 1; j++)
                {
                    if (Avtomobile[j].year > Avtomobile[j + 1].year)
                    {
                        temp = Avtomobile[j];
                        Avtomobile[j] = Avtomobile[j + 1];
                        Avtomobile[j + 1] = temp;
                    }
                }

            }
        }

        public static void TAX(TS[] Avtomobile) {
            Console.WriteLine();
            for (int i = 0; i < Avtomobile.Length; i++) {
                if (Avtomobile[i].mass <= 1500)
                {
                    Console.WriteLine($"{Avtomobile[i].name}:\tTAX per Year = 35$");
                }
                if (Avtomobile[i].mass >= 1500 && Avtomobile[i].mass <= 2000)
                {
                    Console.WriteLine($"{Avtomobile[i].name}:\tTAX per Year = 71$");
                }
                if (Avtomobile[i].mass >= 2000 && Avtomobile[i].mass <= 3000)
                {
                    Console.WriteLine($"{Avtomobile[i].name}:\tTAX per Year = 103$");
                }
                if (Avtomobile[i].mass >= 3000)
                {
                    Console.WriteLine($"{Avtomobile[i].name}:\tTAX per Year = 140$");
                }

            }

        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("How many cars do you want to input?");
            num = Convert.ToInt32(Console.ReadLine());
            string bufName, bufColor, s;
            int bufMass, bufYear, bufPower;
            TS[] Avtomobile = new TS[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write("\nName: ");
                bufName = Console.ReadLine();
                for (; ; )
                {
                    Console.Write("Year: ");
                    s = Console.ReadLine();
                    if (!int.TryParse(s, out bufYear))
                    { Console.WriteLine("Try again!\n"); }
                    else {
                        bufYear = Convert.ToInt32(s);
                        if (bufYear >= 1900 && bufYear <= 2019) { break; }
                        else { Console.WriteLine("Year can be only > 1900 and <2019\n"); }
                    }
                }
                Console.Write("Color: ");
                bufColor = (Console.ReadLine());
                for (; ; )
                {
                    Console.Write("Mass: ");
                    s = Console.ReadLine();
                    if (!int.TryParse(s, out bufMass))
                    { Console.WriteLine("Try again!\n"); }
                    else
                    {
                        bufMass = Convert.ToInt32(s);
                        if (bufMass >= 100 && bufMass <= 100000) { break; }
                        else { Console.WriteLine("Mass can be only > 100 and <100000\n"); }
                    }
                }
                for (; ; )
                {
                    Console.Write("Power: ");
                    s = Console.ReadLine();
                    if (!int.TryParse(s, out bufPower))
                    { Console.WriteLine("Try again!\n"); }
                    else
                    {
                        bufPower = Convert.ToInt32(s);
                        if (bufPower >= 1 && bufPower <= 10000) { break; }
                        else { Console.WriteLine("Power can be only > 0 and <10000\n"); }
                    }
                }
                Avtomobile[i] = new TS(bufName, bufColor, bufYear, bufMass, bufPower);
            }


           // int buf, buf1, num1;
           // Console.WriteLine("\nDo you want to calculate fuel consumption per 100 km?");
            /* for (; ; )
             {
                 Console.WriteLine("\n1. Yes    2. No\nInput: ");
                 s = Console.ReadLine();
                 if (!int.TryParse(s, out buf))
                 { Console.WriteLine("You can choose only 1 or 2!\n"); }
                 else
                 {
                     buf = Convert.ToInt32(s);
                     if (buf == 2) { break; }
                     Console.WriteLine($"\nChoose Your Car from 1 to {num}\nInput: ");

                     for (; ; ) {
                         s = Console.ReadLine();
                         if (!int.TryParse(s, out num1))
                         { Console.WriteLine($"You can choose only from 1 to {num}!\n"); }
                         else
                         {
                             num1 = Convert.ToInt32(s);
                             if (num1 >= 1 && num1 <= num)
                             {
                                 buf = Convert.ToInt32(s);
                                 if (buf == 1 || buf == 2)
                                 {
                                     if (buf == 1)
                                     {

                                         Console.WriteLine("Do you want to include num of passengers?\nInput:");
                                         for (; ; )
                                         {
                                             Console.WriteLine("1. Yes    2. No");
                                             s = Console.ReadLine();
                                             if (!int.TryParse(s, out buf))
                                             { Console.WriteLine("You can choose only 1 or 2!\n"); }
                                             else
                                             {
                                                 buf = Convert.ToInt32(s);
                                                 if (buf == 1 || buf == 2)
                                                 {
                                                     if (buf == 1)
                                                     {
                                                         Console.WriteLine("How many passengers?\nInput: ");
                                                         for (; ; )
                                                         {
                                                             s = Console.ReadLine();
                                                             if (!int.TryParse(s, out buf1))
                                                             { Console.WriteLine("You can choose only form 1 or 20!\n"); }
                                                             else
                                                             {
                                                                 buf1 = Convert.ToInt32(s);
                                                                 Console.Write("\nFuel: ");
                                                                 Console.Write(Avtomobile[num1 - 1].Fuel(buf1));
                                                                 Console.WriteLine(" per 100 km");
                                                                 break;
                                                             }
                                                         }
                                                         break;
                                                     }
                                                     else
                                                     {
                                                         Console.Write("\nFuel: ");
                                                         Console.Write(Avtomobile[num1 - 1].Fuel());
                                                         Console.WriteLine(" per 100 km");
                                                         break;
                                                     }
                                                 }
                                                 else
                                                 {
                                                     Console.WriteLine("You can choose only 1 or 2!\n");
                                                 }
                                             }
                                         }

                                     }

                                 }
                                 break;
                             } else { Console.WriteLine($"You can choose only from 1 to {num}!\n"); }
                         }
                     } //else { Console.WriteLine("You can choose only 1 or 2!\n"); }
                     break;
                 }
             }*/
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("\n1.Info about TS.\n2.TAX.\n3.Sort\n4.Exit");
                s = Console.ReadLine();
                if (s == "4") break;
                switch (s) {
                    case "1": {
                            for (int i = 0; i < num; i++) {
                                Avtomobile[i].Printt();
                            }
                        }; break;
                    case "2": TS.TAX(Avtomobile); break;
                    case "3":
                        {
                            TS.Sort(Avtomobile);
                            for (int i = 0; i < num; i++)
                            {
                                Avtomobile[i].Printt();
                            }
                        }; break;
                    default: Console.WriteLine("Smth is going wrong! Try again!"); break;
                }

                Console.ReadKey();

            }


            //  Console.ReadKey();

        }
    }
}
