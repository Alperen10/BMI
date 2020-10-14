using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double weight;
            double height;
            double bmi;
            weight = double.Parse(textBox1.Text);
            height = double.Parse(textBox2.Text);
            bmi = weight / (height * height);

            if (bmi<18.5)
            {
                label4.Text = bmi + "\nZayıf";
            }
            else if (bmi>18.5 && bmi<25)
            {
                label4.Text = bmi + "\nNormal";
            }
            else if (bmi>25 && bmi <29)
            {
                label4.Text = bmi + "\nFazla kilolu";
            }
            else if (bmi > 30 && bmi < 35)
            {
                label4.Text = bmi + "\nŞişman,birinci derece obez";
            }
            else if (bmi > 35 && bmi < 44.5)
            {
                label4.Text = bmi + "\nŞişman,ikinci derece obez";
            }
            else if (bmi > 45)
            {
                label4.Text = bmi + "\nAşırı şişman,üçüncü derece obez";
            }

        }
    }
}
