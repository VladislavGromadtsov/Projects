using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Human
    {
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public int height { get; set; }

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

        public virtual void Get_Info()
        {
            Console.WriteLine($" Name:  {name}\tSurname:  {surname}\tAge:  {age}\tHeight:  {height}\n\n");
        }

        public void Set_Info(string name, string surname, int age, int height)
        {
            this.age = age;
            this.name = name;
            this.surname = surname;
            this.height = height;
        }
        

    }
}
