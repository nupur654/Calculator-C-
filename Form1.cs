using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondCalculator
{
    public partial class Calculator : Form
    {
        double firstNumber;
        double secondNumber;
        double result;
        string operationPerformed;
        bool isOperationPerformed;



        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void operandNumberButton_click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            if (displayTextBox.Text == "0"||(isOperationPerformed))
            {
                displayTextBox.Clear();
            }
            if (button.Text == ".")
            {
                if (!displayTextBox.Text.Contains("."))
                    displayTextBox.Text = displayTextBox.Text + button.Text;
            
            }else

                displayTextBox.Text = displayTextBox.Text + button.Text;

            isOperationPerformed = false;

        }

        private void operatorButton_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            operationPerformed = button.Text;
            firstNumber = Convert.ToDouble(displayTextBox.Text);
            displayTextBox.Clear();
            DisplayLabel.Text = firstNumber + operationPerformed;

            isOperationPerformed = true;





        }

        private void equalButton_click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(displayTextBox.Text);
            isOperationPerformed = true;

            switch (operationPerformed)
            { 
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "x":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    break;
            
            }
            displayTextBox.Text = result.ToString();


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();

        }

        private void clearEnableButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text= "0";
            result = 0;
        }
    }
}
