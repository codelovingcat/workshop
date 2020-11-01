using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_how_many_digits
{
    public partial class HowManys : Form
    {
        public HowManys()
        {
            InitializeComponent();
        }

        private void btnBasamak_Click(object sender, EventArgs e)
        {
            float number,total, index=0;
            number = float.Parse(txtBasamak.Text);

            
            for (; number >= 10;)
            {
                total = number /= 10;
                index++;
            }
            index++;
            lblBasamak.Text = $"{number} sayısının basamak değeri {index}";
        }
    }
}
