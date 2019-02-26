using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string op = "";
        private bool result = false;
        private bool decPos = false;
        private bool firstPos = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            res.Text = "";
        }

        private void AddEntry(object sender, EventArgs e)
        {

            if (((Button)sender).Text == "+") { op = "+"; decPos = false; firstPos = true; }
            if (((Button)sender).Text == "-") { op = "-"; decPos = false; firstPos = true; }
            if (((Button)sender).Text == "*") { op = "*"; decPos = false; firstPos = true; }
            if (((Button)sender).Text == "/") { op = "/"; decPos = false; firstPos = true; }

            if (result && op == "")
            {
                Clear();
                result = false;
            }
            if (((Button)sender).Text == ".")
            {
                if (!firstPos && !decPos)
                {
                    res.Text += ((Button)sender).Text;
                    decPos = true;
                }

            }
            else
            {
                res.Text += ((Button)sender).Text;
                if (op == "") firstPos = false;
            }

        }

        private void AddNum(object sender, EventArgs e)
        {
            if (result)  // If = was pressed delete the result and start new calculation
            {
                Clear();
                result = false;
            }
            res.Text += ((Button)sender).Text;
            firstPos = false;
        }

        private void AddOperator(object sender, EventArgs e)
        {

            if(op == "") // Only if no operator was pressed accept an operator
            {
                if (((Button)sender).Text == "+") { op = "+"; decPos = false; firstPos = true; }
                if (((Button)sender).Text == "-") { op = "-"; decPos = false; firstPos = true; }
                if (((Button)sender).Text == "*") { op = "*"; decPos = false; firstPos = true; }
                if (((Button)sender).Text == "/") { op = "/"; decPos = false; firstPos = true; }

                res.Text += ((Button)sender).Text;
                result = false;  // If result is true set to false as the calculation continues
            }
        
        }

        private void AddDec(object sender, EventArgs e)
        {
            if(!firstPos && !decPos) // Only if we not on the first Pos of a number and no Decimal point was entered
            {
                res.Text += ((Button)sender).Text;
                decPos = true;
            }
        }

        private void KeyEntry(object sender, KeyPressEventArgs e)
        {

        }


        private void Eql(object sender, EventArgs e)
        {
            string[] numbers = res.Text.Split('+', '-', '*', '/');
            switch (op)
            {
                case "+":
                    res.Text = (Convert.ToDecimal(numbers[0]) + Convert.ToDecimal(numbers[1])).ToString();
                    result = true;
                    break;
                case "-":
                    res.Text = (Convert.ToDecimal(numbers[0]) - Convert.ToDecimal(numbers[1])).ToString();
                    result = true;
                    break;
                case "*":
                    res.Text = (Convert.ToDecimal(numbers[0]) * Convert.ToDecimal(numbers[1])).ToString();
                    result = true;
                    break;
                case "/":
                    res.Text = (Convert.ToDecimal(numbers[0]) / Convert.ToDecimal(numbers[1])).ToString();
                    result = true;
                    break;

            }
            op = "";
        }

        private void Clr(object sender, EventArgs e)
        {
            Clear();
        }

        private void Dev(object sender, EventArgs e)
        {
            res.Text = "This is still in Development please try our other features";
        }

        
    }
}
