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

            label1.Focus();
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
            label1.Focus();

        }

        private void AddDec(object sender, EventArgs e)
        {
            if(!firstPos && !decPos) // Only if we not on the first Pos of a number and no Decimal point was entered
            {
                res.Text += ((Button)sender).Text;
                decPos = true;
            }
            label1.Focus();
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
                catch (IndexOutOfRangeException)
                {
                    result = Convert.ToDecimal(res.Text);
                }
                res.Text = result.ToString();
                resultOutput = true;
                op = "";
                
            }

            label1.Focus();

        }

        private void Clr(object sender, EventArgs e)
        {
            Clear();
            label1.Focus();
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
            label1.Focus();

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
            label1.Focus();
        }

        private void Perc(object sender, EventArgs e)
        {
            if (Regex.IsMatch(res.Text, "\\d+[+*/-]\\d+"))
            {
                Regex reg = new Regex("([+*/-])");
                string[] matchArray = reg.Split(res.Text, 0, 1);
                string[] last2Elements;
                
                if(Regex.IsMatch(matchArray[matchArray.Length - 3], "\\d"))
                {
                    last2Elements = new string[2];
                    Array.Copy(matchArray, matchArray.Length - 2, last2Elements, 0, 2);
                    Array.Resize(ref matchArray, matchArray.Length - 2);
                }
                else
                {
                    last2Elements = new string[3];
                    Array.Copy(matchArray, matchArray.Length - 3, last2Elements, 0, 3);
                    Array.Resize(ref matchArray, matchArray.Length - 3);
                }

                res.Text = String.Join("", matchArray);
                equal.PerformClick();

                if (last2Elements.Length == 2)
                {
                    switch (last2Elements[0])
                    {
                        case "+":
                            res.Text = (Convert.ToDecimal(res.Text) + Convert.ToDecimal(res.Text) * Convert.ToDecimal(last2Elements[1]) / 100).ToString();
                            break;
                        case "-":
                            res.Text = (Convert.ToDecimal(res.Text) - Convert.ToDecimal(res.Text) * Convert.ToDecimal(last2Elements[1]) / 100).ToString();
                            break;
                        case "*":
                            res.Text = (Convert.ToDecimal(res.Text) * Convert.ToDecimal(res.Text) * Convert.ToDecimal(last2Elements[1]) / 100).ToString();
                            break;
                        case "/":
                            res.Text = (Convert.ToDecimal(res.Text) / Convert.ToDecimal(res.Text) * Convert.ToDecimal(last2Elements[1]) / 100).ToString();
                            break;
                        default:
                            break;

                    }
                }
                else
                {
                    switch (last2Elements[0])
                    {
                        case "+":
                            res.Text = (Convert.ToDecimal(res.Text) + Convert.ToDecimal(res.Text) * Convert.ToDecimal(last2Elements[1] + last2Elements[2]) / 100).ToString();
                            break;
                        case "-":
                            res.Text = (Convert.ToDecimal(res.Text) - Convert.ToDecimal(res.Text) * Convert.ToDecimal(last2Elements[1] + last2Elements[2]) / 100).ToString();
                            break;
                        case "*":
                            res.Text = (Convert.ToDecimal(res.Text) * Convert.ToDecimal(res.Text) * Convert.ToDecimal(last2Elements[1] + last2Elements[2]) / 100).ToString();
                            break;
                        case "/":
                            res.Text = (Convert.ToDecimal(res.Text) / Convert.ToDecimal(res.Text) * Convert.ToDecimal(last2Elements[1] + last2Elements[2]) / 100).ToString();
                            break;
                        default:
                            break;

                    }
                }
                resultOutput = true;
            }

            label1.Focus();

        }

        private void KeyEntry(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    num0.PerformClick();
                    break;
                case '1':
                    num1.PerformClick();
                    break;
                case '2':
                    num2.PerformClick();
                    break;
                case '3':
                    num3.PerformClick();
                    break;
                case '4':
                    num4.PerformClick();
                    break;
                case '5':
                    num5.PerformClick();
                    break;
                case '6':
                    num6.PerformClick();
                    break;
                case '7':
                    num7.PerformClick();
                    break;
                case '8':
                    num8.PerformClick();
                    break;
                case '9':
                    num9.PerformClick();
                    break;
                case '+':
                    sum.PerformClick();
                    break;
                case '-':
                    sub.PerformClick();
                    break;
                case '*':
                    mul.PerformClick();
                    break;
                case '/':
                    div.PerformClick();
                    break;
                case '.':
                    dec.PerformClick();
                    break;
                case '\r':
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }


    }
}
