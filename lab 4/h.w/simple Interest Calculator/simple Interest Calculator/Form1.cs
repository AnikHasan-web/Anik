using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simple_Interest_Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

       

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            
            LoadEquationComboBox();
            equationComboBox.SelectedIndex = 0;
            LoadTimeComboBox();
            timeComboBox.SelectedIndex = 5;
        }

        private void LoadTimeComboBox()
        {
            timeComboBox.Items.Add("days(365/Yr)");
            timeComboBox.Items.Add("days(360/Yr)");
            timeComboBox.Items.Add("weeks");
            timeComboBox.Items.Add("months");
            timeComboBox.Items.Add("quarters");
            timeComboBox.Items.Add("years");
        }

        private void LoadEquationComboBox()
        {
            equationComboBox.Items.Add("Total P+1 (A)");
            equationComboBox.Items.Add("Principal (P)");
            equationComboBox.Items.Add("Rate (R)");
            equationComboBox.Items.Add("Time Period (t)");
        }

        private void equationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((equationComboBox.SelectedItem=="Total P+1 (A)") || (equationComboBox.SelectedItem == "Principal (P)") || (equationComboBox.SelectedItem == "Rate (R)"))
            {
                timeComboBox.Visible = true;
                label4.Visible = true;
            }
            else
            {
                timeComboBox.Visible = false;
                label4.Visible = false;
            }
            ///////////////////////////////////////////////////////////////////////
            string equation = equationComboBox.Text;
            if (equation == "Total P+1 (A)")
            {
                showEquationLabel.Text = "A = P ( 1 + rt)";
                label1.Text = "Principal (P): $";
                label2.Text = "Rate (R): %";
                Label3.Text = "Time (t):";
                label4.Text = "per year";
                TextBox1.Text = "amount";
                TextBox2.Text = "rate";
                TextBox3.Text = "#";
            }
            else if (equation == "Principal (P)")
            {
                showEquationLabel.Text = "P = A / ( 1 + rt)";
                label1.Text = "Total P+1(A): $";
                label2.Text = "Rate (R): %";
                Label3.Text = "Time (t):";
                label4.Text = "per year";
                TextBox1.Text = "total amount";
                TextBox2.Text = "rate";
                TextBox3.Text = "#";
            }
            else if (equation == "Rate (R)")
            {
                showEquationLabel.Text = "r = ( 1 / t) ( A / P-1)";
                label1.Text = "Total P+1(A): $";
                label2.Text = "Principal (P): $";
                Label3.Text = "Time (t):";
                label4.Text = "";
                TextBox1.Text = "total amount";
                TextBox2.Text = "amount";
                TextBox3.Text = "#";
            }
            else
            {
                showEquationLabel.Text = "t = ( 1 / r) ( A / P-1)";
                label1.Text = "Total P+1(A): $";
                label2.Text = "Rate(R): %";
                Label3.Text = "Principal (P): $";
                label4.Text = "per year";
                TextBox1.Text = "total amount";
                TextBox2.Text = "rate";
                TextBox3.Text = "amount";
                
            }
        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBox1.Text) || string.IsNullOrWhiteSpace(TextBox2.Text) || string.IsNullOrWhiteSpace(TextBox3.Text))
            {
                MessageBox.Show("Please Enter valid value");
            }
            else
            {
                if (equationComboBox.Text == "Total P+1 (A)")
                {
                    double P = Convert.ToDouble(TextBox1.Text);
                    double R = Convert.ToDouble(TextBox2.Text);
                    double r = R / 100;
                    if (timeComboBox.Text == "days(365/Yr)")
                    {
                        
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 365;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else if (timeComboBox.Text == "days(360/Yr)")
                    {
                       
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 360;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else if (timeComboBox.Text == "weeks")
                    {
                       
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 52;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else if (timeComboBox.Text == "months")
                    {
                        
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 12;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else if (timeComboBox.Text == "quarters")
                    {
                        
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 4;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }
                    else
                    {
                       
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time;
                        double A = P * (1 + r * t);
                        answerTextBox.Text = "A=$" + Convert.ToString(A);
                    }

                }
                else if (equationComboBox.Text == "Principal (P)")
                {
                    double A = Convert.ToDouble(TextBox1.Text);
                    double R = Convert.ToDouble(TextBox2.Text);
                    double r = R / 100;
                    if (timeComboBox.Text == "days(365/Yr)")
                    {
                        
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 365;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else if (timeComboBox.Text == "days(360/Yr)")
                    {
                        
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 360;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else if (timeComboBox.Text == "weeks")
                    {
                        
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 52;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else if (timeComboBox.Text == "months")
                    {
                        
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 12;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else if (timeComboBox.Text == "quarters")
                    {
                       
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 4;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }
                    else
                    {
                        
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time;
                        double P = A / (1 + r * t);
                        answerTextBox.Text = "P=$" + Convert.ToString(P);
                    }

                }
                else if (equationComboBox.Text == "Rate (R)")
                {
                    double A = Convert.ToDouble(TextBox1.Text);
                    double P = Convert.ToDouble(TextBox2.Text);
                    if (timeComboBox.Text == "days(365/Yr)")
                    {
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 365;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else if (timeComboBox.Text == "days(360/Yr)")
                    {
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 360;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else if (timeComboBox.Text == "weeks")
                    {
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 52;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else if (timeComboBox.Text == "months")
                    {
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 12;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else if (timeComboBox.Text == "quarters")
                    {
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time / 4;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }
                    else
                    {
                        double time = Convert.ToDouble(TextBox3.Text);
                        double t = time;
                        double r = (1 / t) / (A / P - 1);
                        answerTextBox.Text = "P=$" + Convert.ToString(r);
                    }

                }
                else
                {
                    double A = Convert.ToDouble(TextBox1.Text);
                    double R = Convert.ToDouble(TextBox2.Text);
                    double P = Convert.ToDouble(TextBox2.Text);
                    double r = R / 100;
                    double t = (1 / r) * (A / P - 1);
                    answerTextBox.Text = "t= " + Convert.ToString(t) + " years";

                }
            }
        }

        private void Clear(object sender, MouseEventArgs e)
        {
            TextBox1.Clear();
            TextBox2.Clear();
            TextBox3.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            answerTextBox.Text = " ";

            TextBox1.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";

        }

        private void timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeComboBox.Text == "days(365/Yr)")
                label4.Text = "per days(365/Yr)";
            else if (timeComboBox.Text == "days(360/Yr)")
                label4.Text = "per days(360/Yr)";
            else if (timeComboBox.Text == "weeks")
                label4.Text = "per weeks";
            else if (timeComboBox.Text == "months")
                label4.Text = "per months";
            else if (timeComboBox.Text == "quarters")
                label4.Text = "per quarters";
            else
                label4.Text = "per year";
        }

        


    }
}
