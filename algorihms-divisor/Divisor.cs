using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorihms_divisor
{
    public partial class Divisor : Form
    {
        public Divisor()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listHesapla.Items.Clear();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(txtNumber.Text);
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    listHesapla.Items.Add(i);
                }
               
            }

        }

        private void btnAsal_Click(object sender, EventArgs e)
        {
            int index = 0;
            int number = Convert.ToInt32(txtNumber.Text);
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    index++;
                }
                if (index == 0)
                {
                    label2.Text = number + " : sayısı asaldır.";
                }
                else
                {
                    label2.Text = number + " : sayısı asal değildir.";
                }
            }
        }
    }
}
