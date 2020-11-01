using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_how_old
{
    public partial class HowOld : Form
    {
        public HowOld()
        {
            InitializeComponent();
        }

        private void btnYas_Click(object sender, EventArgs e)
        {
            int year, age, byear;

            year = Convert.ToInt32(txtYear.Text);
            byear = Convert.ToInt32(txtByear.Text);

            age = year - byear;

            lblYas.Text = age + " : Yaşındasınız.";
        }
    }
}
