using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metoda_bisekcji
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Rules for entering functions:\nNumbers: decimal separator is a dot \nVariable: x or x\nPower: Pow(x,n)\nPrime 2 degree: Sqrt(x)\nWhere: x - variable or number, n - exponent of power\nEuler number: e or E\nNatural logarithm: Log(x,e)\nLogarithm with n logarithm base: Log(x,n)Trigonometric functions: cos(x),sin(x),tan(x).";
        }
    }
}
