using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace name_contact_email_adding
{
    public partial class Form1 : Form
    {
        ListViewItem items = new ListViewItem();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            items.Text = nameTextBox.Text;
            items.SubItems.Add(contactTextBox.Text);
            items.SubItems.Add(emailTextBox.Text);
            listView1.Items.Add(items);
            Clear();

        }


        private void Clear()
        {
            nameTextBox.Clear();
            contactTextBox.Clear();
            emailTextBox.Clear();
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem items = listView1.SelectedItems[0];
            string Name = items.Text;
            string Contact = items.SubItems[1].Text;
            string Email = items.SubItems[2].Text;
            MessageBox.Show("Name: "+Name+"    "+" Contact: "+Contact+"    "+"Email: "+Email);
        }


    }
}
