using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace two_number_plus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            int numberOne, numberTwo, total;

            numberOne = Convert.ToInt32(txt1.Text);
            numberTwo = Convert.ToInt32(txt2.Text);
            total = numberOne + numberTwo;

            lblTotal.Text = "Sayıların toplamı : " + total.ToString();
        }
    }
}
