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
            if(Lb_operator.Text == "+")
            {
                Lbl_show.Text = "Test";
            }
        }
    }
}
