using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace algorithms_largest_number
{
    public partial class LargeNumber : Form
    {
        public LargeNumber()
        {
            InitializeComponent();
        }

        private void btnEnb_Click(object sender, EventArgs e)
        {
            int largeNumber, numberOne, numberTwo, numberThree;
            
            numberOne=Convert.ToInt32 (txt1.Text);
            numberTwo = Convert.ToInt32(txt2.Text);
            numberThree = Convert.ToInt32(txt3.Text);

            largeNumber = Convert.ToInt32(numberOne);
            
            if (numberTwo >largeNumber && numberTwo > numberThree)
            {
                largeNumber = numberTwo;
                lblTotal.Text = largeNumber + " En Büyük Sayıdır.";
            }
            else if (numberThree > largeNumber && numberThree >numberTwo)
            {
                largeNumber = numberThree;
                lblTotal.Text = largeNumber +" En Büyük Sayıdır.";
            }
            else
            {
                lblTotal.Text = largeNumber + " En Büyük Sayıdır.";
            }
        }
    }
}
