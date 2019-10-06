using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_information
{
    public partial class StudentForm : Form
    {
        
        ArrayList students = new ArrayList(); 
        public StudentForm()
        {
            InitializeComponent();
        }

            
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(regTextBox.Text))
            {
                MessageBox.Show("Please insert");
            }
            else
            {
                int regNum = Convert.ToInt32(regTextBox.Text);
                students.Add(firstNameTextBox.Text + " " + lastNameTextBox.Text + "             " + regNum);
                MessageBox.Show("information are saved");
                Clear();
            }
            
        }

        private void ShowaAllButton_Click(object sender, EventArgs e)
        {
           
            string output = string.Empty;
            foreach(var information in students)
            {
                output=output+information+"\n";
            }
            MessageBox.Show("Name" + "             " + "Reg" + "\n"+output);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            
        }
        private void Clear()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            regTextBox.Clear();
        }
    }
}
