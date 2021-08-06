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
        private int value1, value2;
        public int Value1 {
            set;get;
        }
        public int Value2
        {
            set;get;
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

        private void calcTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void oneBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.Text.Length == 0)
            {
                calcTB.Text = oneBTN.Text;
            }
            else
            {
                calcTB.Text = calcTB.Text + "1";
            }
        }
        private void zeroBTN_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (char c in calcTB.Text.ToArray())
            {
                if (c!='0')
                {
                    flag = true;
                }
            }
            if (calcTB.Text.Length == 0)
            {
                calcTB.Text = zeroBTN.Text;
            }
            else if(flag)
            {
                calcTB.Text = calcTB.Text + "0";
            }
            else
            {
                //do nothing
            }
        }

        private void twoBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.Text.Length == 0)
            {
                calcTB.Text = twoBTN.Text;
            }
            else
            {
                calcTB.Text = calcTB.Text + "2";
            }
        }

        private void threeBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.Text.Length == 0)
            {
                calcTB.Text = threeBTN.Text;
            }
            else
            {
                calcTB.Text = calcTB.Text + "3";
            }
        }

        private void fourBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.Text.Length == 0)
            {
                calcTB.Text = fourBTN.Text;
            }
            else
            {
                calcTB.Text = calcTB.Text + "4";
            }
        }

        private void fiveBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.Text.Length == 0)
            {
                calcTB.Text = fourBTN.Text;
            }
            else
            {
                calcTB.Text = calcTB.Text + "5";
            }
        }

        private void sixBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.Text.Length == 0)
            {
                calcTB.Text = sixBTN.Text;
            }
            else
            {
                calcTB.Text = calcTB.Text + "6";
            }
        }

        private void sevenBTN_Click(object sender, EventArgs e)
        {

        }

        private void eightBTN_Click(object sender, EventArgs e)
        {

        }

        private void nineBTN_Click(object sender, EventArgs e)
        {

        }

        private void pointBTN_Click(object sender, EventArgs e)
        {

        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            calcTB.Clear();
        }

        private void backspaceBTN_Click(object sender, EventArgs e)
        {
            if ((String.Compare(calcTB.Text, " ") < 0))
            {
                calcTB.Text = calcTB.Text.Substring(0, calcTB.Text.Length - 1 + 1);
            }
            else
            {
                calcTB.Text = calcTB.Text.Substring(0, calcTB.Text.Length - 1);
            }
        }
    }
}
