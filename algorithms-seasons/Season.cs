using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_seasons
{
    public partial class Season : Form
    {
        public Season()
        {
            InitializeComponent();
        }

        private void btnSeasons_Click(object sender, EventArgs e)
        {
            if (txtSeasons.Text=="Yaz" || txtSeasons.Text == "yaz")
            {
                lblSeasons.Text = "Haziran, Temmuz, Ağustos";
            }
            else if (txtSeasons.Text== "İlkbahar" || txtSeasons.Text == "ilkbahar")
            {
                lblSeasons.Text = " Mart, Nisan, Mayıs";
            }
            else if (txtSeasons.Text== "Sonbahar" || txtSeasons.Text == "sonbahar")
            {
                lblSeasons.Text = "Eylül, Ekim, Kasım";
            }
            else if (txtSeasons.Text== "Kış" || txtSeasons.Text == "kış")
            {
                lblSeasons.Text = " Aralık, Ocak, Şubat";
            }

            if (txtSeasons.Text== "Haziran" || txtSeasons.Text == "Temmuz" || txtSeasons.Text == "Ağustos" || txtSeasons.Text == "haziran" || txtSeasons.Text == "temmuz" || txtSeasons.Text == "ağustos")
            {
                lblSeasons.Text = "Yaz Mevsimi";
            }
            else if (txtSeasons.Text == "Mart" || txtSeasons.Text == "Nisan" || txtSeasons.Text == "Mayıs" || txtSeasons.Text == "mart" || txtSeasons.Text == "nisan" || txtSeasons.Text == "mayıs")
            {
                lblSeasons.Text = "İlkbahar Mevsimi";
            }
            else if (txtSeasons.Text == "Eylül" || txtSeasons.Text == "Ekim" || txtSeasons.Text == "Kasım" || txtSeasons.Text == "eylül" || txtSeasons.Text == "ekim" || txtSeasons.Text == "kasım")
            {
                lblSeasons.Text = "Sonbahar Mevsimi";
            }
            else if (txtSeasons.Text == "Aralık" || txtSeasons.Text == "Ocak" || txtSeasons.Text == "Şubat" || txtSeasons.Text == "aralık" || txtSeasons.Text == "ocak" || txtSeasons.Text == "şubat")
            {
                lblSeasons.Text = "Kış Mevsimi";
            }
            else
            {
                lblSeasons.Text = "Lütfen bir Ay yada Mevsim giriniz.";
            }
        }
       
    }
}
