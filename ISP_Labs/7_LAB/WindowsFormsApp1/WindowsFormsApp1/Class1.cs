using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1
{
    class Class1:IComparable
    {
        public string m { get; set;}
        public string n { get; set;}
        public double NUM { get; set; }
        public Class1(string N, string M)
        {
             n = N;
             m = M;
            NUM = Convert.ToDouble(N) / Convert.ToDouble(M);
        }

        public Class1()
        {
            n = "0";
            m = "0";
            NUM = 0;
        }

        public void VVod(string N, string M)
        {
            n = N;
            m = M;
            NUM = Convert.ToDouble(N) / Convert.ToDouble(M);
        }

        public void Show(System.Windows.Forms.ComboBox comboBox)
        {
            //   return ($"{n}/{m}");
            comboBox.Items.Clear();
            comboBox.Items.Add($"{n}/{m}");
            comboBox.Items.Add(Convert.ToString(NUM));
            comboBox.Items.Add(NUM.ToString("E"));
            comboBox.SelectedItem = 1;

        }

        public  static string operator +(Class1 temp1, Class1 temp2)
        {
            return Convert.ToString(temp1.NUM + temp2.NUM);
        }

        public static string operator -(Class1 temp1, Class1 temp2)
        {
            return Convert.ToString(temp1.NUM - temp2.NUM);
        }


        public static string operator /(Class1 temp1, Class1 temp2)
        {
            return Convert.ToString(temp1.NUM / temp2.NUM);
        }

        public static string operator *(Class1 temp1, Class1 temp2)
        {
            return Convert.ToString(temp1.NUM * temp2.NUM);
        }

        public int Compare(Class1 temp1, Class1 temp2)
        {
            if (temp1.NUM > temp2.NUM) return 1;
            else if (temp1.NUM < temp2.NUM) return -1;
            else return 0;
        }

        public static string operator >(Class1 temp1, Class1 temp2)
        {
            int a  = temp1.Compare(temp1, temp2);
            if (a > 0) return "TRUE!";
            else {
                System.Media.SoundPlayer pl = new System.Media.SoundPlayer(@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\SOUND.wav");
                pl.Play();
                System.Threading.Thread.Sleep(1500);

                return "FALSE";
            }
        }

        public static string operator <(Class1 temp1, Class1 temp2)
        {
            int a = temp1.Compare(temp1, temp2);
            if (a < 0) return "TRUE!";
            else
            {
                System.Media.SoundPlayer pl = new System.Media.SoundPlayer(@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\SOUND.wav");
                pl.Play();
                System.Threading.Thread.Sleep(1500);

                return "FALSE";
            }
        }

        public static string operator ==(Class1 temp1, Class1 temp2)
        {
            int a = temp1.Compare(temp1, temp2);
            if (a == 0) return "TRUE!";
            else
            {
                System.Media.SoundPlayer pl = new System.Media.SoundPlayer(@"C:\PC\EDUCATION\2_SEMESTR_1_K\ISP\SOUND.wav");
                pl.Play();
                System.Threading.Thread.Sleep(1500);

                return "FALSE";
            }
        }

        public static string operator !=(Class1 temp1, Class1 temp2)
        {
            return Convert.ToString(temp1.NUM * temp2.NUM);
        }
        
    }
}
