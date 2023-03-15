using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cout = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "(";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "(";
                }
            }
            else
            {

                txt_display.Text = "2";
            }
        }

        private void txt_display_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_allclear_Click(object sender, EventArgs e)
        {
                txt_display.Text = "0";
                operation = null;
            number2 = null;
            number1 = null;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null && operation == null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "1";
                else if (cout > 0)
                    txt_display.Text = "1";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "1";
                }
            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "1";
                }
            }

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null && operation == null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "2";
                else if (cout > 0)
                    txt_display.Text = "2";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "2";
                }
            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "2";
                }
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null && operation == null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "3";
                else if (cout > 0)
                    txt_display.Text = "3";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "3";
                }
            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "3";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_display.MaxLength = 10;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null && operation == null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "4";
                else if (cout > 0)
                    txt_display.Text = "4";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "4";
                }
            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "4";
                }
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null && operation == null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "5";
                else if (cout > 0)
                    txt_display.Text = "5";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "5";
                }
            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "5";
                }
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null && operation == null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "6";
                else if (cout > 0)
                    txt_display.Text = "6";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "6";
                }
            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "6";
                }
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null && operation == null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "7";
                else if (cout > 0)
                    txt_display.Text = "7";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "7";
                }
            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "7";
                }
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null&& operation==null)
            {

                if (txt_display.Text == "0")
                    txt_display.Text = "8";
                else if (cout > 0)
                    txt_display.Text = "8";

                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "8";
                }        

            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "8";
                }
                else
                {
                    if (operation != null)
                    {
                        if (txt_display.Text == "")
                        {
                            txt_display.Text = "8";
                            number1 = txt_display.Text;
                        }
                        else
                        {
                            txt_display.Text = "8";
                            number1 = txt_display.Text;
                            //string temp = txt_display.Text;
                            //txt_display.Text = temp + "8";
                        }
                    }
                    else
                    {
                        string temp = txt_display.Text;
                        txt_display.Text = temp + "8";
                    }
                }
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null && operation == null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "9";
                else if (cout > 0)
                    txt_display.Text = "9";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "9";
                }
            }
            else
            {

                if (txt_display.Text == "")
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "9";
                }
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = "0";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + "0";
                }
            }
            else
            {

                txt_display.Text = "0";
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            txt_display.Text = "0";
            operation = null;
        }

        private void btn_rightbracket_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != null)
            {
                if (txt_display.Text == "0")
                    txt_display.Text = ")";
                else
                {
                    string temp = txt_display.Text;
                    txt_display.Text = temp + ")";
                }
            }
            else
            {

                txt_display.Text = "2";
            }
        }

        string number1 = "";
        string number2 = "";
        string operation = null;
        string count = "";

        private void button17_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != "0" && operation == null)
            {
                number1 = txt_display.Text;
                txt_display.Text = "";
                operation = "add";
            }
            else
            {
                number2 = txt_display.Text;
                txt_display.Text = (Convert.ToInt32(number1) + Convert.ToInt32(number2)).ToString();
                number1 = txt_display.Text;
            }
        }
        
        private void btn_subtract_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != "0" && operation == null)
            {
                number1 = txt_display.Text;
                txt_display.Text = "";
                operation = "sub";
            }
            else
            {
                number2 = txt_display.Text;
                txt_display.Text = (Convert.ToInt32(number1) - Convert.ToInt32(number2)).ToString();
            }
        }

        private void btn_equalsto_Click(object sender, EventArgs e)
        {
            if (txt_display != null && operation != null)
            {
                number2 = txt_display.Text;
                if (operation == "add")
                    txt_display.Text = (Convert.ToInt32(number1) + Convert.ToInt32(number2)).ToString();
                else if (operation == "sub")
                    txt_display.Text = (Convert.ToInt32(number1) - Convert.ToInt32(number2)).ToString();
                else if (operation == "mul")
                    txt_display.Text = (Convert.ToInt32(number1) * Convert.ToInt32(number2)).ToString();
                else if (operation == "div")
                    txt_display.Text = (Convert.ToInt32(number1) / Convert.ToInt32(number2)).ToString();
                number1 = null;
                number2 = null;
                operation = null;
                cout = 1;
            }
            else
            {
                txt_display.Text = txt_display.Text;
                number1 = null;
                number2 = null;
                operation = null;
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != "0" && operation == null)
            {
                number1 = txt_display.Text;
                txt_display.Text = "";
                operation = "mul";
            }
            else
            {
                number2 = txt_display.Text;
                txt_display.Text = (Convert.ToInt32(number1) * Convert.ToInt32(number2)).ToString();
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (txt_display.Text != "0" && operation == null)
            {
                number1 = txt_display.Text;
                txt_display.Text = "";
                operation = "div";
            }
            else
            {
                number2 = txt_display.Text;
                txt_display.Text = (Convert.ToInt32(number1) / Convert.ToInt32(number2)).ToString();
            }
        }
    }
}
