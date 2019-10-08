using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private string firstName;
        private string lastName;
        private string fathersName;
        private string mothersName;
        private string address;

        private void saveButton_Click(object sender, EventArgs e)
        {
            firstName = firstNameTextBox.Text;
            lastName = lastNameTextBox.Text;
            fathersName = fathersNameTextBox.Text;
            mothersName = mothersNameTextBox.Text;
            address = addressTextBox.Text;
            MessageBox.Show("successfully saved");
            Clear();
        }
        private void showAllInformationButton_Click(object sender, EventArgs e)
        {
            Clear();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
            fathersNameTextBox.Text = fathersName;
            mothersNameTextBox.Text = mothersName;
            addressTextBox.Text=address;
        }
        private void nameButton_Click(object sender, EventArgs e)
        {
            Clear();
            firstNameTextBox.Text = firstName;
            lastNameTextBox.Text = lastName;
        }
        private void parentsNameButton_Click(object sender, EventArgs e)
        {
            Clear();

            fathersNameTextBox.Text = fathersName;
            mothersNameTextBox.Text = mothersName;


        }

        private void addressButton_Click(object sender, EventArgs e)
        {
            Clear();
            addressTextBox.Text = address;
        }
        private void Clear()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            fathersNameTextBox.Clear();
            mothersNameTextBox.Clear();
            addressTextBox.Clear();
        }


        public Form1()
        {
            InitializeComponent();
        }

       
    }
}
