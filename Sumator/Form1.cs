using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sumator
{
    public partial class SumatorNiki : Form
    {
        public SumatorNiki()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            decimal num1 = decimal.Parse(this.textBox1.Text);
            decimal num2 = decimal.Parse(this.textBox2.Text);
            
            

            decimal sum1 = num1 + num2;
            decimal sum2 = num1 - num2;
            decimal sum3 = num1 * num2;
            decimal sum4 = num1 / num2;

            textBoxSum1.Text = sum1.ToString();
            textBoxSum2.Text = sum2.ToString();
            textBoxSum3.Text = sum3.ToString();
            textBoxSum4.Text = sum4.ToString();
        }
    }
}
