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
        private string op = "+";  // If has value an operator can't be entered (By default has value beacuse cant enter a operator on start of calculation)
        private bool resultOutput = false; // Set to true after the '=' sign has been pressed and result been displayed
        private bool decPos = false; // Set to true if a decimal point has been entered, not allowing another one for the same number
        private bool firstPos = true; // Set to true if no interger has been enterd yet for the next number (stops wrong entries for the start of a number)
        private int minusCount = 1; // Counts how many '-' has been entered not allowing more than 2
        public Form1()
        {
            InitializeComponent();
        }

        private void Clear()  // Clears the output screen
        {
            res.Text = "";
        }


        private void AddNum(object sender, EventArgs e)
        {
            if (resultOutput)  // If = was pressed delete the result and start new calculation
            {
                Clear();
                resultOutput = false;
            }
            res.Text += ((Button)sender).Text; // Adds the interger to the output string
            firstPos = false; // interger is not anymore the first pos of tne number
            op = ""; // last entry wasn't a operator, allows for an operator to be entered
            minusCount = 0; // Setting minusCount back to 0

            label1.Focus();  // Move focus away from the buttons
        }

        private void AddOperator(object sender, EventArgs e)
        {

            if(op == "" || ((Button)sender).Text == "-" && minusCount <2  ) // Only if no operator was pressed accept an operator (except for '-' if only 1 '-' was pressed)
            {
                if (((Button)sender).Text == "+") { op = "+"; decPos = false; firstPos = true; minusCount++; }
                if (((Button)sender).Text == "-") { op = "-"; decPos = false; firstPos = true; minusCount++; }
                if (((Button)sender).Text == "*") { op = "*"; decPos = false; firstPos = true; minusCount++; }
                if (((Button)sender).Text == "/") { op = "/"; decPos = false; firstPos = true; minusCount++; }

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

            string[] matchArray = (res.Text != "") ? reg.Split(res.Text, 0, 1) : new string[1] { "e" };  // Checks if the output box is not empty, if it is add a random letter in to the array
           
            if (Regex.IsMatch(matchArray[matchArray.Length - 1], "\\d")) // Make sure the last entry was a didgit
            {
                
                try    // Try the calculation if Exeption is thrown deal with it in the catch statement
                {
                    switch (matchArray[1])  // Calculate the first two numbers 
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

                    for (int j = 3; j < matchArray.Length; j += 2)  // Calculates the rest of the numbers
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

        private void Clr(object sender, EventArgs e)  // Clears the screen
        {
            Clear();
            label1.Focus();
        }

        private void Sqr(object sender, EventArgs e)  
        {
            if (Regex.IsMatch(res.Text, "\\d"))  // Check if an interger was entered
            {
                if(Regex.IsMatch(res.Text, "[+*/-]"))  // If their is an operator entered calculate first
                {
                    equal.PerformClick();
                }

                res.Text = (Convert.ToDecimal(res.Text) * Convert.ToDecimal(res.Text)).ToString();  // Square
                resultOutput = true;
            }
            label1.Focus();

        }

        private void Sqrt(object sender, EventArgs e)
        {
            if (Regex.IsMatch(res.Text, "\\d"))  // Check if an interger was entered
            {
                if (Regex.IsMatch(res.Text, "[+*/-]")) // If their is an operator entered calculate first
                {
                    equal.PerformClick();
                }

                res.Text = (Math.Sqrt(Convert.ToDouble(res.Text))).ToString(); // Square root
                resultOutput = true;
            }
            label1.Focus();
        }

        private void Perc(object sender, EventArgs e)
        {
            if (Regex.IsMatch(res.Text, "\\d+[+*/-]\\d+"))  // Check if a calculation was entered
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
