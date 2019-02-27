using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private string op = "+";
        private bool resultOutput = false;
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

        //private void AddEntry(object sender, EventArgs e)
        //{

        //    if (((Button)sender).Text == "+") { op = "+"; decPos = false; firstPos = true; }
        //    if (((Button)sender).Text == "-") { op = "-"; decPos = false; firstPos = true; }
        //    if (((Button)sender).Text == "*") { op = "*"; decPos = false; firstPos = true; }
        //    if (((Button)sender).Text == "/") { op = "/"; decPos = false; firstPos = true; }

        //    if (resultOutput && op == "")
        //    {
        //        Clear();
        //        resultOutput = false;
        //    }
        //    if (((Button)sender).Text == ".")
        //    {
        //        if (!firstPos && !decPos)
        //        {
        //            res.Text += ((Button)sender).Text;
        //            decPos = true;
        //        }

        //    }
        //    else
        //    {
        //        res.Text += ((Button)sender).Text;
        //        if (op == "") firstPos = false;
        //    }

        //}

        private void AddNum(object sender, EventArgs e)
        {
            if (resultOutput)  // If = was pressed delete the result and start new calculation
            {
                Clear();
                resultOutput = false;
            }
            res.Text += ((Button)sender).Text;
            firstPos = false;
            op = "";
        }

        private void AddOperator(object sender, EventArgs e)
        {
            //Regex reg = new Regex("[+-*/]");

            if(op == "" || ((Button)sender).Text == "-" ) // Only if no operator was pressed accept an operator
            {
                if (((Button)sender).Text == "+") { op = "+"; decPos = false; firstPos = true; }
                if (((Button)sender).Text == "-") { op = "-"; decPos = false; firstPos = true; }
                if (((Button)sender).Text == "*") { op = "*"; decPos = false; firstPos = true; }
                if (((Button)sender).Text == "/") { op = "/"; decPos = false; firstPos = true; }

                res.Text += ((Button)sender).Text;
                resultOutput = false;  // If result is true set to false as the calculation continues
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
            Regex reg = new Regex("([+*/-])");
            decimal result = 0;

            string[] matchArray = reg.Split(res.Text,0,1);

            if (Regex.IsMatch(matchArray[matchArray.Length - 1], "\\d")) // Make sure the last entry was a didgit
            {
                
                try    // Try the calculation if Exeption is thrown deal with it in the catch statement
                {
                    switch (matchArray[1])
                    {
                        case "+":
                            result = Decimal.Parse(matchArray[0]) + Decimal.Parse(matchArray[2]);
                            break;
                        case "-":
                            result = Decimal.Parse(matchArray[0]) - Decimal.Parse(matchArray[2]);
                            break;
                        case "*":
                            result = Convert.ToDecimal(matchArray[0]) * Convert.ToDecimal(matchArray[2]);
                            break;
                        case "/": 
                                result = Convert.ToDecimal(matchArray[0]) / Convert.ToDecimal(matchArray[2]);
                            break;
                        default:
                            break;

                    }

                    for (int j = 3; j < matchArray.Length; j += 2)
                    {
                        switch (matchArray[j])
                        {
                            case "+":
                                result += Convert.ToDecimal(matchArray[j + 1]);
                                break;
                            case "-":
                                result -= Convert.ToDecimal(matchArray[j + 1]);
                                break;
                            case "*":
                                result *= Convert.ToDecimal(matchArray[j + 1]);
                                break;
                            case "/":
                                result /= Convert.ToDecimal(matchArray[j + 1]);
                                break;
                            default:
                                break;

                        }
                    }
                }
                catch (FormatException)  // If second number is negative concatinate the negative symbol with the number
                {
                    
                    switch (matchArray[1])
                    {
                        case "+":
                            result = Decimal.Parse(matchArray[0]) + Decimal.Parse(matchArray[3]+matchArray[4]);
                            break;
                        case "-":
                            result = Decimal.Parse(matchArray[0]) - Decimal.Parse(matchArray[3] + matchArray[4]);
                            break;
                        case "*":
                            result = Convert.ToDecimal(matchArray[0]) * Convert.ToDecimal(matchArray[3] + matchArray[4]);
                            break;
                        case "/":
                            result = Convert.ToDecimal(matchArray[0]) / Convert.ToDecimal(matchArray[3] + matchArray[4]);
                            break;
                        default:
                            break;

                    }

                    for (int j = 5; j < matchArray.Length; j += 4)
                    {
                        switch (matchArray[j])
                        {
                            case "+":
                                result += Convert.ToDecimal(matchArray[j + 2] + matchArray[j+3]);
                                break;
                            case "-":
                                result -= Convert.ToDecimal(matchArray[j + 2] + matchArray[j+3]);
                                break;
                            case "*":
                                result *= Convert.ToDecimal(matchArray[j + 2] + matchArray[j+3]);
                                break;
                            case "/":
                                result /= Convert.ToDecimal(matchArray[j + 2] + matchArray[j+3]);
                                break;
                            default:
                                break;

                        }
                    }
                    
                }
                catch (DivideByZeroException er)  // Divided by 0 error
                {

                    res.Text = er.Message;
                    return;
                }
                res.Text = result.ToString();
                resultOutput = true;
                op = "";
                
            }
            
        }

        private void Clr(object sender, EventArgs e)
        {
            Clear();
        }

        private void Dev(object sender, EventArgs e)
        {
            res.Text = "This is still in Development please try our other features";
        }

        private void Sqr(object sender, EventArgs e)
        {
            if (Regex.IsMatch(res.Text, "\\d"))
            {
                if(Regex.IsMatch(res.Text, "[+*/-]"))
                {
                    equal.PerformClick();
                }

                res.Text = (Convert.ToDecimal(res.Text) * Convert.ToDecimal(res.Text)).ToString();
                resultOutput = true;
            }
            
        }

        private void Sqrt(object sender, EventArgs e)
        {
            if (Regex.IsMatch(res.Text, "\\d"))
            {
                if (Regex.IsMatch(res.Text, "[+*/-]"))
                {
                    equal.PerformClick();
                }

                res.Text = (Math.Sqrt(Convert.ToDouble(res.Text))).ToString();
                resultOutput = true;
            }

        }

        private void Perc(object sender, EventArgs e)
        {
            if (Regex.IsMatch(res.Text, "\\d"))
            {
                if (Regex.IsMatch(res.Text, "[+*/-]"))
                {
                    equal.PerformClick();
                }

                res.Text = (Convert.ToDecimal(res.Text) * Convert.ToDecimal(res.Text)).ToString();
                resultOutput = true;
            }

        }


    }
}
