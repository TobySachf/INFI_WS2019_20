using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Try_Windows_Calc
{
    public partial class Form1 : Form
    {
        private int numray1_index = 0;
        private int numray2_index = 0;
        private int calcNum1, calcNum2;
        private double calcResult;
        
        private string calcOperator, calcOperatorDisplay;

        private bool second = false, displayResult = false;
        
        char[] numray1 = new char[100];
        char[] numray2 = new char[100];
        
        
        
        public Form1()
        {
            InitializeComponent();
            Lbl_displayNum1.Text = null;
            Lbl_displayNum2.Text = null;
            Lbl_displayOperator.Text = null;

        }

        //Dials
        private void Btn_dialZero_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('0');
            DisplayDial();
        }
        private void Btn_dialOne_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('1');
            DisplayDial();
        }

        private void Btn_dialTwo_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('2');
            DisplayDial();
        }
        
        private void Btn_dialThree_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('3');
            DisplayDial();
        }
        private void Btn_dialFour_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('4');
            DisplayDial();
        }
        private void Btn_dialFive_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('5');
            DisplayDial();
        }
        private void Btn_dialSix_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('6');
            DisplayDial();
        }
        private void Btn_dialSeven_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('7');
            DisplayDial();
        }
        private void Btn_dialEight_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('8');
            DisplayDial();
        }
        private void Btn_dialNine_Click(object sender, EventArgs e)
        {
            if (displayResult)
            {
                Lbl_displayNum1.Text = calcResult.ToString();
            }
            
            AddDial('9');
            DisplayDial();
        }
        private void Btn_plus_Click(object sender, EventArgs e)
        {
            second = true;
            calcOperator = "plus";
            Lbl_displayOperator.Text = "+";
        }
        
        private void Btn_minus_Click(object sender, EventArgs e)
        {
            second = true;
            calcOperator = "minus";
            Lbl_displayOperator.Text = "-";
        }
        
        private void Btn_multiplied_Click(object sender, EventArgs e)
        {
            second = true;
            calcOperator = "multiplied";
            Lbl_displayOperator.Text = "*";
        }
        private void Btn_divided_Click(object sender, EventArgs e)
        {
            second = true;
            calcOperator = "divided";
            Lbl_displayOperator.Text = "/";
        }


        private void Btn_getResult_Click(object sender, EventArgs e)
        {
            calcNum1 = Convert.ToInt16(string.Join("", numray1));
            calcNum2 = Convert.ToInt16(string.Join("", numray2));

            if (calcOperator == "plus")
            {
                calcOperatorDisplay = "+";
                calcResult = calcNum1 + calcNum2;
            }
            else if (calcOperator == "minus")
            {
                calcOperatorDisplay = "-";
                calcResult = calcNum1 - calcNum2;
            }
            else if (calcOperator == "multiplied")
            {
                calcOperatorDisplay = "*";
                calcResult = calcNum1 * calcNum2;
            }
            else if (calcOperator == "divided")
            {
                calcOperatorDisplay = "/";
                calcResult = calcNum1 / calcNum2;
            }

            Lbl_displayNum1.Text = Lbl_displayNum1.Text + " " + calcOperatorDisplay + " " +  Lbl_displayNum2.Text;
            Lbl_displayOperator.Text = "=";
            Lbl_displayNum2.Text = calcResult.ToString();

            Array.Clear(numray1, 0, numray1.Length);
            Array.Clear(numray2, 0, numray2.Length);

            numray1 = calcResult.ToString().ToCharArray();
            
            numray1_index = numray1.Length;
            numray2_index = 0;
            second = false;

            displayResult = true;
        }
        private void Btn_dialCE_Click(object sender, EventArgs e)
        {
            Lbl_displayNum1.Text = null;
            Lbl_displayNum2.Text = null;
            Lbl_displayOperator.Text = null;
            
            Array.Clear(numray1, 0, numray1.Length);
            Array.Clear(numray2, 0, numray2.Length);
                
            numray1_index = 0;
            numray2_index = 0;
            second = false;
        }

        private void AddDial(char dial)
        {
            if (second == false)
            {
                numray1[numray1_index] = dial;
                numray1_index++;
            }
            else
            {
                numray2[numray2_index] = dial;
                numray2_index++;
            }
        }

        private void DisplayDial()
        {
            StringBuilder sb1 = new StringBuilder();         
            foreach (var item in numray1)
            {
                sb1.AppendFormat("{0}", item);
            }
            
            StringBuilder sb2 = new StringBuilder();         
            foreach (var item in numray2)
            {

                    sb2.AppendFormat("{0}", item);
            }

            Lbl_displayNum1.Text = sb1.ToString();
            Lbl_displayNum2.Text = sb2.ToString();
        }



    }
}