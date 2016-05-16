using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class FibonacciForm : Form
    {
        public FibonacciForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            output.Text = "";
            long firstNum = 0;
            long secondNum = 1;
            long thirdNum = 1;
            int count = Convert.ToInt32(CountInput.Text);
           if (count > 0 && count < 1000)
            {
                output.AppendText(firstNum + ", " + secondNum);
                for (int n = 1; n < count; n++)
                {
                    thirdNum = secondNum + firstNum;
                    if (thirdNum >= 0)
                    {
                        output.AppendText(", " + thirdNum);
                        firstNum = secondNum;
                        secondNum = thirdNum;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose a number higher than 0 and less than 74 for the count due to overflow issues.");
            }
        }
    }
}

