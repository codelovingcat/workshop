using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agorithms_fibonacci
{
    public partial class Fibonacci : Form
    {
        int number1 = 1, number2 = 1, result;
        public Fibonacci()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                result = number1 + number2; ;

                number1 = number2;
                number2 = result;

                listBox1.Items.Add(result);

            }
        }
    }
}
