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
            Txt_MyPersonA.Text = MyPerson.RetrunPersons();
        }

        private void Btn_disPerson2_Click_1(object sender, EventArgs e)
        {
            Txt_MyPersonB.Text = ClassmateA.RetrunPersons();
        }

        private void Btn_disPerson3_Click_1(object sender, EventArgs e)
        {
            Txt_MyPersonC.Text = ClassmateB.RetrunPersons();
        }

        private void Btn_changePersonB_Click(object sender, EventArgs e)
        {
            ClassmateA.ChangeValues(Txt_lastNamePersonB.Text, Txt_firstNamePersonB.Text, Txt_birthdayPersonB.Text);
        }

        private void Btn_changePersonC_Click(object sender, EventArgs e)
        {
            ClassmateB.ChangeValues(Txt_lastNamePersonC.Text, Txt_firstNamePersonC.Text, Txt_birthdayPersonB.Text);
        }
    }
}