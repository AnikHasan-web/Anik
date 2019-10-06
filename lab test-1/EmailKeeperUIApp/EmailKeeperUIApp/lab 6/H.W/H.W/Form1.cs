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

namespace H.W
{
    public partial class BookInformationForm : Form
    {
        public BookInformationForm()
        {
            InitializeComponent();
        }
         private void clear()
        {
            isbnTextBox.Clear();
            nameTextBox.Clear();

        }
        Dictionary<long, string> bookDetails = new Dictionary<long, string>();
        private void addButton_Click(object sender, EventArgs e)
        {
            string contains = isbnTextBox.Text;
            int i = contains.Length;
            if (string.IsNullOrEmpty(isbnTextBox.Text) || string.IsNullOrEmpty(nameTextBox.Text))
            {
               MessageBox.Show("Please insert");
            }
            else
            {
                if(i!=13)
                {
                    MessageBox.Show("Please insert valid ISBN Number");
                    
                }
                else
                {
                    long isbn = long.Parse(isbnTextBox.Text);
                    bookDetails.Add(isbn, nameTextBox.Text);
                    informationListBox.Items.Add(isbnTextBox.Text);
                    informationListBox.Items.Add(nameTextBox.Text);
                    clear();
                    isbnTextBox.Focus();
                }

            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
             searchListBox.Items.Clear();
             if (isbnRadioButton.Checked == true)
             {
                 
                 Dictionary<long, string>.KeyCollection keyColl = bookDetails.Keys;
                 long bookName = long.Parse(searchTextBox.Text);
                 if(keyColl.Contains(bookName))
                 {
                     searchListBox.Items.Add(bookDetails[bookName]);
                     searchTextBox.Clear();
                 }
                 else
                 {
                     MessageBox.Show("items not matched");
                 }
 
             }

             else if (nameRadioButton.Checked == true)
             {
                 
                 Dictionary<long, string>.ValueCollection valueColl = bookDetails.Values;
                 string bookName = Convert.ToString(searchTextBox.Text);
                 if(valueColl.Contains(bookName))
                 {
                     searchListBox.Items.Add(bookName);
                     searchTextBox.Clear();
                 }
                 else
                 {
                     MessageBox.Show("items not matched");
                 }
                 
             }
             
        }

        private void BookInformationForm_Load(object sender, EventArgs e)
        {
            isbnRadioButton.Checked = true;
        }

    }
}
