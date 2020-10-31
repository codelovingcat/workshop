using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_negative_positive_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            /// sayının 2 ye bölündüğü zamanki tam halinin kendisine eşit olup olmadığına bakabiliriz.
            /// Mod almadan sayının negatif pozitif olma hali.
             
            float number;
            number = Convert.ToInt32(txtNumber.Text);
            if (Convert.ToInt32(number / 2) == (number / 2))
            {
                lblTotal.Text = number + "  Sayısı Çifttir.";
            }
            else
            {
                lblTotal.Text = number + "  Sayısı Tektir.";
            }
        }
    }
}
