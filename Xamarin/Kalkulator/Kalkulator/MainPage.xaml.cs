using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Kalkulator
{
    public partial class MainPage : ContentPage
    {
        private double firstNumber;
        private bool isOperatorClicked;
        private string operatorName;
        public MainPage()
        {
            InitializeComponent();
        }

        private void number(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (equation.Text == "0" || isOperatorClicked == true)
            {
                isOperatorClicked = false;
                equation.Text = button.Text;
                equationChar.Text = button.Text;
            }
            else
            {
                equation.Text += button.Text;
                equationChar.Text += button.Text;
            }

            if (equationChar.Text.Contains("="))
            {
                equation.Text = button.Text;
                equationChar.Text = button.Text;
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            equation.Text = "0";
            equationChar.Text = "0";
        }

        private void ClearChar(object sender, EventArgs e)
        {
            var number = equation.Text;
            var number2 = equationChar.Text;
            if (number != "0")
            {
                number = number.Remove(number.Length - 1);
                number2 = number2.Remove(number2.Length - 1);
                if(string.IsNullOrEmpty(number))
                {
                    equation.Text = "0";
                    equationChar.Text = "0";
                }
                else
                {
                    equation.Text = number;
                    equationChar.Text = number2;
                }
            }
        }

        private void Fraction(object sender, EventArgs e)
        {
            bool condition = equation.Text.Contains(".");
            bool condition2 = equationChar.Text.Contains(".");
            if(condition == false && condition2 == false)
            {
                equation.Text += ".";
                equationChar.Text += ".";
            }
        }

        private void OperatorHandling(object sender, EventArgs e)
        {
            var button = sender as Button;
            isOperatorClicked = true;
            operatorName = button.Text;
            firstNumber = Convert.ToDouble(equation.Text);
            if(!equationChar.Text.Contains(operatorName) && equationChar.Text != "0")
            {
                if (operatorName == "1/x")
                    equationChar.Text = "1/(" + firstNumber + ")";
                else if (operatorName == "x^2")
                    equationChar.Text += "^2";
                else if (operatorName == "√x")
                    equationChar.Text = "√" + firstNumber;
                else
                    equationChar.Text += operatorName;
            }
        }
        private void OperatorResult(object sender, EventArgs e)
        {
            try
            {
                double secondNumber = Convert.ToDouble(equation.Text);
                string finalResult = Calculate(firstNumber, secondNumber).ToString("0.####");
                equation.Text = finalResult;

                if (operatorName == "1/x")
                    equationChar.Text = "1/(" + firstNumber  + ") = " + finalResult;
                else if (operatorName == "x^2")
                    equationChar.Text = firstNumber + "^2 = " + finalResult;
                else if (operatorName == "√x")
                    equationChar.Text = "√" + firstNumber + " = " + finalResult;
                else if(operatorName == "+")
                    equationChar.Text = firstNumber + "+" + secondNumber + " = " + finalResult;
                else if (operatorName == "-")
                    equationChar.Text = firstNumber + "-" + secondNumber + " = " + finalResult;
                else if (operatorName == "*")
                    equationChar.Text = firstNumber + "*" + secondNumber + " = " + finalResult;
                else
                    equationChar.Text = firstNumber + "/" + secondNumber + " = " + finalResult;

            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "OK");
            }
        }
        public double Calculate(double firstNumber, double secondNumber)
        {
            double result = 0;
            if (operatorName == "+")
            {
                result = firstNumber + secondNumber;
            }
            else if (operatorName == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if (operatorName == "*")
            {
                result = firstNumber * secondNumber;
            }
            else if (operatorName == "/")
            {
                result = firstNumber / secondNumber;
            }
            else if (operatorName == "1/x")
            {
                result = 1 / firstNumber;
            }
            else if (operatorName == "x^2")
            {
                result = Math.Pow(firstNumber, 2);
            }
            else if (operatorName == "√x")
            {
                result = Math.Sqrt(firstNumber);
            }
            return result;
        }

        
    }
}
