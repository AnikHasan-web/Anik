using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HelloWorld : Form
    {
        public HelloWorld()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumberTextBox.Text) || string.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Please fill up Both the text file first");
            }
            else
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                double result = firstNumber + secondNumber;
                resultTextBox.Text = Convert.ToString(result);
            }
        }

        private void subButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumberTextBox.Text) || string.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Please fill up Both the text file first");
            }
            else
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                double result = firstNumber - secondNumber;
                resultTextBox.Text = Convert.ToString(result);
            }
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumberTextBox.Text) || string.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Please fill up Both the text file first");
            }
            else
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                double result = firstNumber * secondNumber;
                resultTextBox.Text = Convert.ToString(result);
            }
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNumberTextBox.Text) || string.IsNullOrEmpty(secondNumberTextBox.Text))
            {
                MessageBox.Show("Please fill up Both the text file first");
            }
            else
            {
                double firstNumber = Convert.ToDouble(firstNumberTextBox.Text);
                double secondNumber = Convert.ToDouble(secondNumberTextBox.Text);
                double result = firstNumber / secondNumber;
                resultTextBox.Text = Convert.ToString(result);
            }
        }
    }
}
