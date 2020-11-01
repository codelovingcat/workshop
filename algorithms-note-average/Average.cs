using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_note_average
{
    public partial class Average : Form
    {
        public Average()
        {
            InitializeComponent();
        }

        private void btnOrtalama_Click(object sender, EventArgs e)
        {
            int ortalama, vize, final;

            final = Convert.ToInt32(txtFinal.Text);
            vize = Convert.ToInt32(txtVize.Text);

            ortalama = vize + final;
            ortalama= ortalama / 2;

            if (ortalama <= 100 && ortalama >= 85)
            {
                lblTotal.Text = "Ortalamanız : " + ortalama + " Notunuz : " + 5;
            }
            else if (ortalama < 85 && ortalama >= 70)
            {
                lblTotal.Text = "Ortalamanız : " + ortalama + " Notunuz : " + 4;
            }
            else if (ortalama < 70 && ortalama >= 55)
            {
                lblTotal.Text = "Ortalamanız : " + ortalama + " Notunuz : " + 3;
            }
            else if (ortalama < 55 && ortalama >= 45)
            {
                lblTotal.Text = "Ortalamanız : " + ortalama + " Notunuz : " + 2;
            }
            else if (ortalama < 45 && ortalama >= 25)
            {
                lblTotal.Text = "Ortalamanız : " + ortalama + " Notunuz : " + 1;
            }
            else if (ortalama < 25 && ortalama >= 0)
            {
                lblTotal.Text = "Ortalamanız : " + ortalama + " Notunuz : " + 0;
            }
        }
    }
}
