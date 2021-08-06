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
        private float value1, value2;
        private char operation;
        private bool calcDone = false;
        public float Value1 {
            set;get;
        }
        public float Value2
        {
            set;get;
        }
        public char Operation
        {
            set; get;
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
            pointBTN.Enabled = false;
        }
        void enableAllButtons() {
            oneBTN.Enabled = true;
            twoBTN.Enabled = true;
            threeBTN.Enabled = true;
            fourBTN.Enabled = true;
            fiveBTN.Enabled = true;
            sixBTN.Enabled = true;
            sevenBTN.Enabled = true;
            eightBTN.Enabled = true;
            nineBTN.Enabled = true;
            zeroBTN.Enabled = true;
            pointBTN.Enabled = true;
        }
        private void calcTB_TextChanged(object sender, EventArgs e)
        {
            if (calcTB.Text.Length>9) {
                //MessageBox.Show("Exceeded digit limit(10)");
                disableAllButtons();
            }
            else
            {
                enableAllButtons();
            }
        }

        private void calcTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void oneBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
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
            
        }
        private void zeroBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
            {
                bool flag = false;
                foreach (char c in calcTB.Text.ToArray())
                {
                    if (c != '0')
                    {
                        flag = true;
                    }
                }
                if (calcTB.Text.Length == 0)
                {
                    calcTB.Text = zeroBTN.Text;
                }
                else if (flag)
                {
                    calcTB.Text = calcTB.Text + "0";
                }
                else
                {
                    //do nothing
                }
            }
        }

        private void twoBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
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
        }

        private void threeBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
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
        }

        private void fourBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
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
        }

        private void fiveBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
            {
                if (calcTB.Text.Length == 0)
                {
                    calcTB.Text = fiveBTN.Text;
                }
                else
                {
                    calcTB.Text = calcTB.Text + "5";
                }
            }
        }

        private void sixBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
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
        }

        private void sevenBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
            {
                if (calcTB.Text.Length == 0)
                {
                    calcTB.Text = sevenBTN.Text;
                }
                else
                {
                    calcTB.Text = calcTB.Text + "7";
                }
            }
        }

        private void eightBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
            {
                if (calcTB.Text.Length == 0)
                {
                    calcTB.Text = eightBTN.Text;
                }
                else
                {
                    calcTB.Text = calcTB.Text + "8";
                }
            }
        }

        private void nineBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
            {
                if (calcTB.Text.Length == 0)
                {
                    calcTB.Text = nineBTN.Text;
                }
                else
                {
                    calcTB.Text = calcTB.Text + "9";
                }
            }
        }

        private void pointBTN_Click(object sender, EventArgs e)
        {
            if (!calcDone)
            {
                bool dotNai = true;
                char[] chars = calcTB.Text.ToCharArray();
                foreach (char c in chars)
                {
                    if (c == '.')
                    {
                        dotNai = false;
                    }
                }
                if (dotNai)
                {
                    calcTB.Text = calcTB.Text + ".";
                }
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            calcTB.Clear();
            calcDone = false;
        }

        private void plusminusBTN_Click(object sender, EventArgs e)
        {
                if (calcTB.TextLength > 0)
                {
                    char[] chars = calcTB.Text.ToCharArray();
                    if (chars[0] != '-')
                    {
                        calcTB.Text = "-" + calcTB.Text;
                    }
                    else
                    {
                        string text = calcTB.Text;
                        float main = float.Parse(text);
                        main = -1 * main;
                        text = main.ToString();
                        calcTB.Text = text;
                    }

                }
        }

        private void squareBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength > 0)
            {
                float number = float.Parse(calcTB.Text);
                number = number * number;
                historyLB.Text = calcTB.Text + " ^ 2 = ";
                calcTB.Text = number.ToString();
                calcDone = true;
            }
        }

        private void divideBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength>0)
            {
                Value1 = float.Parse(calcTB.Text);
                string labelhist = Value1 +" "+ divideBTN.Text+" ";
                historyLB.Text = labelhist;
                Operation = '/';
                calcTB.Clear();
            }
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

        private void plusBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength > 0)
            {
                Value1 = float.Parse(calcTB.Text);
                string labelhist = Value1 + " " + plusBTN.Text + " ";
                historyLB.Text = labelhist;
                Operation = '+';
                calcTB.Clear();
            }
        }

        private void clearentireBTN_Click(object sender, EventArgs e)
        {
            Value1 = 0;
            Value2 = 0;
            calcTB.Clear();
            historyLB.Text = "Calculation History";
            calcDone = false;
        }

        private void onebyxBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength > 0)
            {
                float result = 1 / float.Parse(calcTB.Text);
                historyLB.Text = 1+" / "+ calcTB.Text+" = ";
                calcTB.Text = result.ToString();

            }
        }

        private void multiBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength > 0)
            {
                Value1 = float.Parse(calcTB.Text);
                string labelhist = Value1 + " " + multiBTN.Text + " ";
                historyLB.Text = labelhist;
                Operation = '*';
                calcTB.Clear();
            }
        }

        private void minusBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength > 0)
            {
                Value1 = float.Parse(calcTB.Text);
                string labelhist = Value1 + " " + minusBTN.Text + " ";
                historyLB.Text = labelhist;
                Operation = '-';
                calcTB.Clear();
            }
        }

        private void rootBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength > 0)
            {
                double number = double.Parse(calcTB.Text);
                number = Math.Sqrt(number);
                historyLB.Text = rootBTN.Text + calcTB.Text+"= ";
                calcTB.Text = number.ToString();
                calcDone = true;
            }
        }

        private void percentBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength > 0)
            {
                Value1 = float.Parse(calcTB.Text);
                string labelhist = Value1 + " " + percentBTN.Text + " ";
                historyLB.Text = labelhist;
                Operation = '%';
                calcTB.Clear();
            }
        }

        private void equalsBTN_Click(object sender, EventArgs e)
        {
            if (calcTB.TextLength > 0)
            {
                Value2 = float.Parse(calcTB.Text);
                if (Operation == '/')
                {
                    float result = Value1 / Value2;
                    historyLB.Text = historyLB.Text + " " + Value2 + " =";
                    calcTB.Text = result.ToString();
                }
                else if (Operation=='+')
                {
                    float result = Value1 + Value2;
                    historyLB.Text = historyLB.Text + " " + Value2 + " =";
                    calcTB.Text = result.ToString();
                }
                else if (Operation == '*')
                {
                    float result = Value1 * Value2;
                    historyLB.Text = historyLB.Text + " " + Value2 + " =";
                    calcTB.Text = result.ToString();
                }
                else if (Operation == '-')
                {
                    float result = Value1 - Value2;
                    historyLB.Text = historyLB.Text + " " + Value2 + " =";
                    calcTB.Text = result.ToString();
                }
                else if (Operation == '%')
                {
                    Value2 = Value2 / 100;
                    float result = Value1 * Value2;
                    historyLB.Text = historyLB.Text + " " + Value2 + " =";
                    calcTB.Text = result.ToString();
                }
            }
        }
    }
}
