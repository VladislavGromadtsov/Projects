using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class HELP
    {
        public void Input(System.IO.StreamReader streamReader, Football[] X, int z)
        {
            for (int i = 0; i < z; i++)
            {
                string Name, Surname, c;
                int age, h, zp, n,m;
                Name = streamReader.ReadLine();
                Surname = streamReader.ReadLine();
                age = Convert.ToInt32(streamReader.ReadLine());
                h = Convert.ToInt32(streamReader.ReadLine());
                zp = Convert.ToInt32(streamReader.ReadLine());
                n = Convert.ToInt32(streamReader.ReadLine());
                c = (streamReader.ReadLine());
                if (i % 2 == 1) m = 1;
                else m = 0;
                X[i] = new Football(Name,Surname,age,h,zp,n,c,m);
            }
        }

        public void Input(System.IO.StreamReader streamReader, Bascketball[] X, int z)
        {
            for (int i = 0; i < z; i++)
            {
                string Name, Surname, c;
                int age, h, zp, n,m;
                Name = streamReader.ReadLine();
                Surname = streamReader.ReadLine();
                age = Convert.ToInt32(streamReader.ReadLine());
                h = Convert.ToInt32(streamReader.ReadLine());
                zp = Convert.ToInt32(streamReader.ReadLine());
                n = Convert.ToInt32(streamReader.ReadLine());
                c = (streamReader.ReadLine());
                if (i % 2 == 1) m = 1;
                else m = 0;
                X[i] = new Bascketball(Name, Surname, age, h, zp, n, c,m);

            }
        }

        public void Input(System.IO.StreamReader streamReader, Hockey[] X, int z)
        {
            for (int i = 0; i < z; i++)
            {
                string Name, Surname, c;
                int age, h, zp, n, m;
                Name = streamReader.ReadLine();
                Surname = streamReader.ReadLine();
                age = Convert.ToInt32(streamReader.ReadLine());
                h = Convert.ToInt32(streamReader.ReadLine());
                zp = Convert.ToInt32(streamReader.ReadLine());
                n = Convert.ToInt32(streamReader.ReadLine());
                c = (streamReader.ReadLine());
                // g = Convert.ToInt32(streamReader.ReadLine());
                // m = Convert.ToInt32(streamReader.ReadLine());
                if (i % 2 == 1) m = 1;
                else m = 0;
                X[i] = new Hockey(Name, Surname, age, h, zp, n, c,m);
            }
        }

        public string Show(Football[] X, int z)
        {
            string Text = "--------------------------------\n";
            for (int i = 0; i < z; i++)
            {
                Text += "Name: " + X[i].name + "\n";
                Text += "Surname: " + X[i].surname + "\n";
                Text += "Age: " +  Convert.ToString(X[i].age) + "\n";
                Text += "Height: " + Convert.ToString(X[i].height) + "\n";
                Text += "Salary: " + Convert.ToString(X[i].salary) + "\n";
                Text += "Num: " + Convert.ToString(X[i].num) + "\n";
                Text += "Team: " + X[i].comm + "\n";
                //Text += "Count of the goals: " + Convert.ToString(X[i].goals) + "\n";
                //  Text += "Count of the matches: " + Convert.ToString(X[i].matches) + "\n";
                Text += "--------------------------------\n";
            }
            return Text;
        }

        public string Show(Bascketball[] X, int z)
        {
            string Text = "--------------------------------\n";
            for (int i = 0; i < z; i++)
            {
                Text += "Name: " + X[i].name + "\n";
                Text += "Surname: " + X[i].surname + "\n";
                Text += "Age: " + Convert.ToString(X[i].age) + "\n";
                Text += "Height: " + Convert.ToString(X[i].height) + "\n";
                Text += "Salary: " + Convert.ToString(X[i].salary) + "\n";
                Text += "Num: " + Convert.ToString(X[i].num) + "\n";
                Text += "Team: " + X[i].comm + "\n";
                //  Text += "Count of the goals: " + Convert.ToString(X[i].goals) + "\n";
                //Text += "Count of the matches: " + Convert.ToString(X[i].matches) + "\n";
                Text += "--------------------------------\n";
            }
            return Text;
        }
        public string Show(Hockey[] X, int z)
        {
            string Text = "--------------------------------\n";
            for (int i = 0; i < z; i++)
            {
                Text += "Name: " + X[i].name + "\n";
                Text += "Surname: " + X[i].surname + "\n";
                Text += "Age: " + Convert.ToString(X[i].age) + "\n";
                Text += "Height: " + Convert.ToString(X[i].height) + "\n";
                Text += "Salary: " + Convert.ToString(X[i].salary) + "\n";
                Text += "Num: " + Convert.ToString(X[i].num) + "\n";
                Text += "Team: " + X[i].comm + "\n";
                //Text += "Count of the goals: " + Convert.ToString(X[i].goals) + "\n";
                //Text += "Count of the matches: " + Convert.ToString(X[i].matches) + "\n";
                Text += "--------------------------------\n";
            }
            return Text;
        }
    }
}
