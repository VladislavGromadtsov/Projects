using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_Norm
{
    class Human
    {
        protected string name;
        protected string surname;
        protected int age;
        protected int height;

        public Human()
        {
            this.age = 0;
            this.name = "None";
            this.surname = "None";
            this.height = 0;
        }
        public Human(string name, string surname, int age, int height)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.height = height;
        }

        public void Get_Info()
        {
            Console.WriteLine ( $" Name:  {name}\tSurname:  {surname}\tAge:  {age}\tHeight:  {height}\n\n" );
        }

        public void Set_Info(string name, string surname, int age, int height)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.height = height;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string SurName
        {
            get { return surname; }
            set { surname = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string bufstr;
            int bufint,buf;
            bool res;

            Human[] human = new Human[3];
            for (int i = 0; i < 3; i++)
            {
                human[i] = new Human();
                Console.Write("\n\nName:  ");
                input = Console.ReadLine();
                human[i].Name = input;
                Console.Write("Surname:  ");
                input = Console.ReadLine();
                human[i].SurName = input;
                for (; ; )
                {
                    Console.Write("Age:  ");
                    input = Console.ReadLine();
                    res = int.TryParse(input, out bufint);
                    if (res == true)
                    {
                        human[i].Age = int.Parse(input);
                        if (human[i].Age>0 && human[i].Age<135) break;
                        else Console.WriteLine("Invalid input!");
                    }
                    else { Console.WriteLine("Invalid input!"); }
                }
                for (; ; )
                {
                    Console.Write("Height:  ");
                    input = Console.ReadLine();
                    res = int.TryParse(input, out bufint);
                    if (res == true)
                    {
                        human[i].Height = int.Parse(input);
                        if (human[i].Height > 0 && human[i].Height < 250) break;
                        else Console.WriteLine("Invalid input!");
                    }
                    else { Console.WriteLine("Invalid input!"); }
                }
            }
            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("1. Get info");
                Console.WriteLine("2. Change info");
                Console.WriteLine("3. Exit");
                input = Console.ReadLine();
                if (input == "3") {
                    Console.Clear();
                    Console.ReadKey();
                    break;
                }
                switch (input)
                {
                    case "1":
                        {
                            Console.Clear();
                            for (int i = 0; i < 3; i++)
                            {
                                human[i].Get_Info();
                            }
                            Console.ReadKey();
                        };break;
                    case "2":
                        {

                            Console.Clear();
                            for (; ; )
                            {
                                Console.Write("\nChoose num:  ");
                                input = Console.ReadLine();
                                res = int.TryParse(input, out bufint);
                                if (res == true)
                                {
                                    bufint = int.Parse(input);
                                    if (bufint > 0 && bufint < 4)
                                    {
                                        Console.Write("\n\nName:  ");
                                        input = Console.ReadLine();
                                        human[bufint-1].Name = input;
                                        Console.Write("\n\nSurname:  ");
                                        input = Console.ReadLine();
                                        human[bufint - 1].SurName = input;
                                        for (; ; )
                                        {
                                            Console.Write("\n\nAge:  ");
                                            input = Console.ReadLine();
                                            res = int.TryParse(input, out buf);
                                            if (res == true)
                                            {
                                                human[bufint - 1].Age = int.Parse(input);
                                                if (human[bufint - 1].Age > 0 && human[bufint - 1].Age < 135) break;
                                                else Console.WriteLine("Invalid input!");
                                            }
                                            else { Console.WriteLine("Invalid input!"); }
                                        }
                                        for (; ; )
                                        {
                                            Console.Write("\n\nHeight:  ");
                                            input = Console.ReadLine();
                                            res = int.TryParse(input, out buf);
                                            if (res == true)
                                            {
                                                human[bufint - 1].Height = int.Parse(input);
                                                if (human[bufint - 1].Height > 0 && human[bufint - 1].Height < 250) break;
                                                else Console.WriteLine("Invalid input!");
                                            }
                                            else { Console.WriteLine("Invalid input!"); }
                                        }
                                        break;
                                    }
                                    else Console.WriteLine("Invalid input!");
                                }
                                else { Console.WriteLine("Invalid input!"); }
                            }
                        };break;
                    default:
                        {
                            Console.Clear();
                            Console.WriteLine("Smth is wrong!");
                            Console.ReadKey();
                        };break;

                }
            }
        }
    }
}
