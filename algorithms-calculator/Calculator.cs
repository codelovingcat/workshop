using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        private void btnKare_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Kare Alan ve Çevresini Hesaplama";
            lblbirincikenar.Text = "Birinci kenar :";

            btnHesapla.Visible = true;
            btnDik.Visible = false;

            lblUzun.Visible = false;
            txtUzun.Visible = false;
            panel1.Visible = true;
        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Dikdörtgen Alan ve Çevresini Hesaplama";
            lblbirincikenar.Text = "Kısa kenar :";

            btnHesapla.Visible = false;
            btnDik.Visible = true;

            panel1.Visible = true;
            lblUzun.Visible = true;
            txtUzun.Visible = true;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int birinciKenar;
            int alan, cevre;

            birinciKenar = Convert.ToInt32(txtkenar1.Text);

            cevre = birinciKenar * 4;
            alan = birinciKenar * birinciKenar;

            lblCevreSonuc.Text = cevre.ToString();
            lblAlanSonuc.Text = alan.ToString();
        }

        private void btnDik_Click(object sender, EventArgs e)
        {
            int uzun, kısa;
            int alan, cevre;

            uzun = Convert.ToInt32(txtkenar1.Text);
            kısa = Convert.ToInt32(txtUzun.Text);

            alan = kısa * uzun;
            cevre = (2 * kısa) + (2 * uzun);

            lblAlanSonuc.Text = alan.ToString();
            lblCevreSonuc.Text = cevre.ToString();
        }
    }
}
