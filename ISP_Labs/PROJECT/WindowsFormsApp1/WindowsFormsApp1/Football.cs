using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Football : Sportsmen 
    {
        //public int goals { get; set; }
        //public int matches { get; set; }
        public string comm { get; set; }
        public int num { get; set; }
        public int marr { get; set; }

        public Football(string name, string surname, int age, int height, int salary, int num, string comm, int marr) : base(name, surname, age, height, salary)
        {
            this.comm = comm;
            //this.matches = matches;
            this.num = num;
            this.marr = marr;
        }

        public override void Get_Info()
        {
            Console.WriteLine($" Name:  {name}\nSurname:  {surname}\nAge:  {age}\nHeight:  {height}\nSalary:  {salary}\nNum:  {num}\n\nTeam:  {comm}\n--------------------------------------------------------------------------");
        }

    }
}
