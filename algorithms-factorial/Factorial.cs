using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_factorial
{
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            int factorial=1, number, total;

            number = Convert.ToInt32(txtFactorial.Text);

            for (int i = 1; i <= number; i++)
            {
                total = factorial;
                factorial = i * total;
                lblFactorial.Text = factorial.ToString();
            }
        }
    }
}
