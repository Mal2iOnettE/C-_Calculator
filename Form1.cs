using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double FirstNum;
        string Operation;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOne_Click(object sender, EventArgs e)
        {
            if(showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "1";
            }
            else
            {
                showText.Text = showText.Text + "1";
            }
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
           
                showText.Text = showText.Text + "0";
           

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "2";
            }
            else
            {
                showText.Text = showText.Text + "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "3";
            }
            else
            {
                showText.Text = showText.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "4";
            }
            else
            {
                showText.Text = showText.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "5";
            }
            else
            {
                showText.Text = showText.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "6";
            }
            else
            {
                showText.Text = showText.Text + "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "7";
            }
            else
            {
                showText.Text = showText.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "8";
            }
            else
            {
                showText.Text = showText.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (showText.Text == "0" && showText.Text != null)
            {
                showText.Text = "9";
            }
            else
            {
                showText.Text = showText.Text + "9";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FirstNum = double.Parse(showText.Text);
            showText.Text = " ";
            Operation = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            FirstNum = double.Parse(showText.Text);
            showText.Text = " ";
            Operation = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            FirstNum = double.Parse(showText.Text);
            showText.Text =  " ";
            Operation = "x";
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            FirstNum = double.Parse(showText.Text);
            showText.Text = " ";
            Operation = "÷";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            showText.Text = "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            showText.Text = showText.Text + ".";

        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double SecoundNum;
            double Result;

            SecoundNum = Convert.ToDouble(showText.Text);

            if(Operation == "+")
            {
                Result = Math.Round(FirstNum + SecoundNum,4);
                showText.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Operation == "-")
            {
                Result = Math.Round(FirstNum - SecoundNum,4);
                showText.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Operation == "x")
            {
                Result = Math.Round(FirstNum * SecoundNum,4);
                showText.Text = Convert.ToString(Result);
                FirstNum = Result;
            }
            if (Operation == "÷")
            {
                if (SecoundNum == 0)
                {
                    showText.Text = "Can not Devide by ZERO";
                }
                else
                {
                    Result =Math.Round (FirstNum / SecoundNum,4);
                    showText.Text = Convert.ToString(Result);
                    FirstNum = Result;
                }
            }
        }


    }
}
