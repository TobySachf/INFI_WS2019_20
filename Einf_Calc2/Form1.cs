using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einf_Calc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Txt_input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_result_Click(object sender, EventArgs e)
        {
            double conNumber1, conNumber2;
            string result;

            try
            {
                string curItem = Lb_operator.SelectedItem.ToString();

                if (curItem == "+")
                {
                    if (double.TryParse(Txt_input1.Text, out conNumber1) && double.TryParse(Txt_input2.Text, out conNumber2))
                    {
                        result = (conNumber1 + conNumber2).ToString();
                    }
                    else
                    {
                        result = "Error: Not a valid number";
                    } 
                    Lbl_show.Text = result;
                }
                if (curItem == "-")
                {
                    if (double.TryParse(Txt_input1.Text, out conNumber1) && double.TryParse(Txt_input2.Text, out conNumber2))
                    {
                        result = (conNumber1 - conNumber2).ToString();
                    }
                    else
                    {
                        result = "Error: Not a valid number";
                    }
                    Lbl_show.Text = result;
                }
                if (curItem == "*")
                {
                    if (double.TryParse(Txt_input1.Text, out conNumber1) && double.TryParse(Txt_input2.Text, out conNumber2))
                    {
                        result = (conNumber1 * conNumber2).ToString();
                    }
                    else
                    {
                        result = "Error: Not a valid number";
                    }
                    Lbl_show.Text = result;
                }
                if (curItem == "/")
                {
                    if (double.TryParse(Txt_input1.Text, out conNumber1) && double.TryParse(Txt_input2.Text, out conNumber2))
                    {
                        result = (conNumber1 / conNumber2).ToString();
                    }
                    else
                    {
                        result = "Error: Not a valid number";
                    }
                    Lbl_show.Text = result;
                }
            }
            catch
            {
                Lbl_show.Text = "Error: Choose operator!";
            }

        }
    }
}
