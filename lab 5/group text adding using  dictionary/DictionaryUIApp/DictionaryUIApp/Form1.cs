using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> userDetails = new Dictionary<string, string>() ;

        private void clear()
        {
            idTextBox.Clear();
            detailsTextBox.Clear();

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idTextBox.Text) || string.IsNullOrEmpty(detailsTextBox.Text))
            {
                MessageBox.Show("Please insert");
            }
            else
            {
                userDetails.Add(idTextBox.Text, detailsTextBox.Text);
                MessageBox.Show("Data Have Been saved :)");
                clear();
                idTextBox.Focus();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (userDetails.ContainsKey(idSearchTextBox.Text))
            {

                MessageBox.Show("id:" + " " + idSearchTextBox.Text +"\n"+"Details: " +userDetails[idSearchTextBox.Text]);
            }
        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string,string> items in userDetails)
            {
                MessageBox.Show("items:"+items);
            }
        }
    }
}
