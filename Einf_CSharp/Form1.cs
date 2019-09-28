using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einf_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            Lbl_status_motor.Text = "Motor on: " + Txt_value.Text + "%";
            Lbl_status_motor.BackColor = Color.Green;
            Lbl_status_motor.ForeColor = Color.White;
            Lbl_status_motor.Left = Btn_start.Location.X;
        }

        private void Btn_stop_Click(object sender, EventArgs e)
        {
            Lbl_status_motor.Text = "Motor off!";
            Lbl_status_motor.BackColor = Color.Red;
            Lbl_status_motor.ForeColor = Color.White;
            Lbl_status_motor.Left = Btn_stop.Location.X;
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            Lbl_status_motor.Text = "__Motor__";
            Lbl_status_motor.BackColor = Color.Yellow;
            Lbl_status_motor.ForeColor = Color.Black;
            Lbl_status_motor.Left = Btn_reset.Location.X;
        }

        private void Txt_value_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
