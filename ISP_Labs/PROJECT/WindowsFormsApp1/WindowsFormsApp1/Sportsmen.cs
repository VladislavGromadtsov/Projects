using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Sportsmen : Human, IComparable
    {
        public int salary { get; set; }
        public Sportsmen(string name, string surname, int age, int height, int salary) : base(name, surname, age, height)
        {
            this.salary = salary;  
        }

        public int CompareTo(string N, string S)
        {
            int i = surname.CompareTo(S);
            int j = name.CompareTo(N);
            if (i == 0)
            {
                return j;
            }
            else
            {
                return i;
            }
        }
    }
}
