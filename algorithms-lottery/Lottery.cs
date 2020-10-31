using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_lottery
{
    public partial class Lottery : Form
    {
        int click = 0;
        public Lottery()
        {
            InitializeComponent();
        }

        private void btnSayisal_Click(object sender, EventArgs e)
        {
            click++;
            Random random = new Random();
            int[] rastgele = new int[6];
            for (int i = 0; i < 6; i++)
            {
                rastgele[i] = random.Next(1, 50);
                listNumber.Items.Add(rastgele[i]);

                if (click % 2 == 1 || click % 2 == 0)
                {
                    lblTik.Text = "Oynanan Kolon : " + click;
                }
            }
            listNumber.Items.Add("**********");
            //Array.Sort(rastgele); İstersek böyle sıralama yapabiliriz.

            lbl1.Text = rastgele[0].ToString();
            lbl2.Text = rastgele[1].ToString();
            lbl3.Text = rastgele[2].ToString();
            lbl4.Text = rastgele[3].ToString();
            lbl5.Text = rastgele[4].ToString();
            lbl6.Text = rastgele[5].ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            listNumber.Items.Clear();
        }
    }
}
