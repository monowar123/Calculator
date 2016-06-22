using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        decimal temp1, value;
        bool plus = false, minus = false, multiply = false, divition = false;
        bool flag1 = false, flag2 = false;
        char ch;
        double memory;
        public void Func_Clear()
        {
            output.ResetText();
            flag1 = false;
            flag2 = true;
        }

        public Form1()
        {
            InitializeComponent();
            labelM.Visible = false;
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "1";
            }
            else
            {
                output.Text = output.Text + "1";
            }
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "2";
            }
            else
            {
                output.Text = output.Text + "2";
            }
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "3";
            }
            else
            {
                output.Text = output.Text + "3";
            }
        }
        private void button_4_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "4";
            }
            else
            {
                output.Text = output.Text + "4";
            }
        }
        private void button_5_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "5";

            }
            else
            {
                output.Text = output.Text + "5";
            }
        }
        private void button_6_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "6";
            }
            else
            {
                output.Text = output.Text + "6";
            }
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "7";
            }
            else
            {
                output.Text = output.Text + "7";
            }
        }
        private void button_8_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "8";
            }
            else
            {
                output.Text = output.Text + "8";
            }
        }
        private void button_9_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "9";
            }
            else
            {
                output.Text = output.Text + "9";
            }
        }
        private void button_0_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                Func_Clear();
                output.Text = "0";
            }
            else
            {
                if (output.Text == "")
                {
                    return;
                }
                else
                {
                    output.Text = output.Text + "0";
                }
            }
        }

        private void plus_button_Click(object sender, EventArgs e)
        {
            if (output.Text == "")      
            {
                return;
            }
            if (flag2)       //addition with plus button
            {
                Calculation(ch);
                flag2 = false;
            }
            else            //addition with equal button
            {
                output.Tag = output.Text;
            }
            plus = true;
            flag1 = true;
            ch = '+';
        }

        private void minus_button_Click(object sender, EventArgs e)
        {
            if (output.Text == "")    
            {
                return;
            }
            if (flag2)                  
            {
                Calculation(ch);
                flag2 = false;
            }
            else
            {
                output.Tag = output.Text;
            }
            minus = true;
            flag1 = true;
            ch = '-';
        }

        private void multiplication_button_Click(object sender, EventArgs e)
        {
            if (output.Text == "")
            {
                return;
            }
            if (flag2)
            {
                Calculation(ch);
                flag2 = false;
            }
            else
            {
                output.Tag = output.Text;
            }
            multiply = true;
            flag1 = true;
            ch = '*';
        }

        private void divition_button_Click(object sender, EventArgs e)
        {
            if (output.Text == "")
            {
                return;
            }
            if (flag2)
            {
                Calculation(ch);
                flag2 = false;
            }
            else
            {
                output.Tag = output.Text;
            }
            divition = true;
            flag1 = true;
            ch = '/';
        }

        private void Sqrt_button_Click(object sender, EventArgs e)
        {
            double var = Math.Sqrt(Convert.ToDouble(output.Text));
            output.Text = var.ToString();
        }

        private void persent_button_Click(object sender, EventArgs e)
        {
            double value = (Convert.ToDouble(output.Tag)) * (Convert.ToDouble(output.Text)) / 100;
            output.Text = value.ToString();
            //output.Tag = output.Text;
        }

        private void invers_button_Click(object sender, EventArgs e)
        {
            output.Text=Convert.ToString(1/(Convert.ToDecimal(output.Text)));
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            switch(ch)
            {
                case '+':
                        if (plus)       //normal addition
                        {
                            try
                            {
                                temp1 = Convert.ToDecimal(output.Text);   //assign the second value in temp
                                Calculation(ch);
                            }
                            catch
                            {
                                return;
                            }
                        }
                        else            //continuous addition
                        {
                            try
                            {
                                value = Convert.ToDecimal(output.Text) + temp1;
                                output.Text = Convert.ToString(value);
                                //output.Tag = output.Text;
                            }
                            catch
                            {
                                return;
                            }
                        }
                        plus = false;
                        break;
                case '-':
                        if (minus)       
                        {
                            try
                            {
                                temp1 = Convert.ToDecimal(output.Text);   
                                Calculation(ch);
                            }
                            catch
                            {
                                return;
                            }
                        }
                        else            //continuous 
                        {
                            try
                            {
                                value = Convert.ToDecimal(output.Text) - temp1;
                                output.Text = Convert.ToString(value);
                                //output.Tag = output.Text;
                            }
                            catch
                            {
                                return;
                            }
                        }
                        minus = false;
                        break;
                case '*':
                        if (multiply)
                        {
                            try
                            {
                                temp1 = Convert.ToDecimal(output.Text);
                                Calculation(ch);
                            }
                            catch
                            {
                                return;
                            }
                        }
                        else            //continuous 
                        {
                            try
                            {
                                value = Convert.ToDecimal(output.Text) * temp1;
                                output.Text = Convert.ToString(value);
                                //output.Tag = output.Text;
                            }
                            catch
                            {
                                return;
                            }
                        }
                        multiply = false;
                        break;
                case '/':
                        if (divition)
                        {
                            try
                            {
                                temp1 = Convert.ToDecimal(output.Text);
                                Calculation(ch);
                            }
                            catch
                            {
                                return;
                            }
                        }
                        else            //continuous 
                        {
                            try
                            {
                                value = Convert.ToDecimal(output.Text) / temp1;
                                output.Text = Convert.ToString(value);
                                //output.Tag = output.Text;
                            }
                            catch
                            {
                                return;
                            }
                        }
                        divition = false;
                        break;
                default: break;
            }               //end of switch case...
            flag1 = true;
            flag2 = false;
            output.Tag = null;
        }               ///end of equal button...

        private void back_button_Click(object sender, EventArgs e)
        {
            try
            {
                output.Text = output.Text.Remove(output.Text.Length - 1);
            }
            catch
            {
                return;
            }
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            output.ResetText();
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            output.ResetText();
            output.Tag = null;
            ch = 'a';
            plus = false; minus = false; multiply = false; divition = false;
            flag1 = false; flag2=false;
        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            if (flag1)
            {
                output.ResetText();
                output.Text = "0.";
                flag1 = false;
                flag2 = true;
            }
            if (output.Text.Contains("."))
            {
                return;
            }
            else
            {
                if (output.Text == "")
                {
                    output.Text = "0.";
                }
                else
                {
                    output.Text = output.Text + ".";
                }
            }
        }

        private void output_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Remove the character
        }

        private void aboutCalculatorToolStripMenuItem_Click(object sender, EventArgs e)  // show the about window
        {
            About_Calculator aa = new About_Calculator();
            aa.Show();
        }

        private void plus_or_minus_button_Click(object sender, EventArgs e)
        {
            if (output.Text.Contains("-"))
            {
                output.Text = output.Text.Remove(0, 1);
            }
            else
            {
                if (Convert.ToDouble(output.Text) == 0.0)
                    return;
                else
                    output.Text = "-" + output.Text;
            }
        
        }

        public void Calculation(char cc)
        {
            bool errorFlag = false;
            switch (cc)
            {
                case '+':
                    output.Text = Convert.ToString(Convert.ToDecimal(output.Tag) + Convert.ToDecimal(output.Text));
                    break;
                case '-':
                    output.Text = Convert.ToString(Convert.ToDecimal(output.Tag) - Convert.ToDecimal(output.Text));
                    break;
                case '*':
                    output.Text = Convert.ToString(Convert.ToDecimal(output.Tag) * Convert.ToDecimal(output.Text));
                    break;
                case '/':
                    try
                    {
                        output.Text = Convert.ToString(Convert.ToDecimal(output.Tag) / Convert.ToDecimal(output.Text));
                    }
                    catch (DivideByZeroException pp)
                    {
                        MessageBox.Show(pp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorFlag = true;   
                    }
                    break;
                default: break;
            }
            //output.Text = Convert.ToString(value);
            output.Tag = output.Text;
            if (errorFlag)
            {
                output.ResetText();
                output.Tag = null;
                ch = 'a';
                plus = false; minus = false; multiply = false; divition = false;
                flag1 = false; flag2 = false;
                errorFlag=false;
            }
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Converter aa = new Converter();
            aa.Show();
        }

        private void button_MC_Click(object sender, EventArgs e)
        {
            memory = 0;
            labelM.Visible = false;
        }

        private void button_MR_Click(object sender, EventArgs e)
        {
            output.Text = memory.ToString();
            flag1 = true;
        }

        private void button_MS_Click(object sender, EventArgs e)
        {
            if (output.Text != "")
            {
                memory = Convert.ToDouble(output.Text);
                labelM.Visible = true;
                flag1 = true;
            }
        }

        private void button_MM_Click(object sender, EventArgs e)  //momory +
        {
            memory += Convert.ToDouble(output.Text);
            labelM.Visible = true;
            flag1 = true;
        }
    }
}