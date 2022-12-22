using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insertion_sort
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int num3;
        public int num4;
        public int num5;
        public int num6;
        public int[] array = new int[6]; 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            array = new int[6];
            number1.Text = "";
            number2.Text = "";
            number3.Text = "";
            number4.Text = "";
            number5.Text = "";
            number6.Text = "";
            rsl.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(number1.Text);
            num2 = int.Parse(number2.Text);
            num3 = int.Parse(number3.Text);
            num4 = int.Parse(number4.Text);
            num5 = int.Parse(number5.Text);
            num6 = int.Parse(number6.Text);
            array = new int[] { num1, num2, num3, num4, num5, num6 };

            for (int i=1; i< array.Length; i++)
            {
                var key=array[i];
                int j= i-1 ;

                while (j>=0 && array[j] >key)
                {
                     array[j+1] = array [j];
                    j=j-1 ;
                    array[j+1] = key;
                }

            }
            string sorted_Array=string.Join (",", array);
            // عشان اقدر استخدم المصفوفه لازم احولها لسترينج عشان اقدر اعرضها 
            rsl.Text= sorted_Array;
   
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
