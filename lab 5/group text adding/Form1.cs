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

namespace group_text_adding
{
    public partial class Form1 : Form
    {
        private Hashtable ht = new Hashtable();
        public Form1()
        {
            InitializeComponent();

        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addIsbnTextBox.Text) || string.IsNullOrEmpty(addDetailsTextBox.Text))
            {
                MessageBox.Show("Please insert");
            }
            else
            {
                ht.Add(addIsbnTextBox.Text, addDetailsTextBox.Text);
                Clear();
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string strValue = (string)ht[findIsbnTextBox.Text];

            if (string.IsNullOrEmpty(findDetailsTextBox.Text=strValue) )
            {
                findDetailsTextBox.Text="Not Found";
                Clear();
            }
            else
            {
                findDetailsTextBox.Text = strValue;
                addIsbnTextBox.Text = findIsbnTextBox.Text;
                addDetailsTextBox.Text = strValue;
            }
        }
        private void Clear()
        {
            addIsbnTextBox.Clear();
            addDetailsTextBox.Clear();
        }
    }
}
