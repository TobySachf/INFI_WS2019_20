using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Einf_Class2
{
    public partial class Form1 : Form
    {
        public Persons MyPerson;
        public Persons ClassmateA = new Persons("Mustermann","Max");
        public Persons ClassmateB = new Persons("Musterfrau","Anna");

        public Form1()
        {
            InitializeComponent();
            MyPerson =  new Persons();
        }

        private void Btn_disPerson1_Click(object sender, EventArgs e)
        {
            Txt_MyPersons.Text = MyPerson.RetrunPersons();
        }

        private void Btn_disPerson2_Click(object sender, EventArgs e)
        {
            Txt_MyPersons.Text = ClassmateA.RetrunPersons();
        }

        private void Btn_disPerson3_Click(object sender, EventArgs e)
        {
            Txt_MyPersons.Text = ClassmateB.RetrunPersons();
        }


    }
}