using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_20_42161_1_
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void oneBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.Text.Length==0)
            {
                calcTB.Text = oneBTN.Text;
            }
            else
            {
                calcTB.Text = calcTB.Text + "1";
            }
        }
        void disableAllButtons()
        {
            oneBTN.Enabled = false;
            twoBTN.Enabled = false;
            threeBTN.Enabled = false;
            fourBTN.Enabled = false;
            fiveBTN.Enabled = false;
            sixBTN.Enabled = false;
            sevenBTN.Enabled = false;
            eightBTN.Enabled = false;
            nineBTN.Enabled = false;
            zeroBTN.Enabled = false;
        }
        private void calcTB_TextChanged(object sender, EventArgs e)
        {
            if (calcTB.Text.Length>10) {
                disableAllButtons();
                MessageBox.Show("Exceeded digit limit(10)");
            }
        }
    }
}
