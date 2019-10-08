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
         Dictionary<string, string> bookDetails = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
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
                    MessageBox.Show("Please insert 13 digit valid ISBN Number");
                    
                }
                else
                {
                    Dictionary<string, string>.KeyCollection keyColl = bookDetails.Keys;
                    string isbn = Convert.ToString(isbnTextBox.Text);
   
                    if (keyColl.Contains(isbn))
                    {
                        MessageBox.Show("This Item are already Added");
                    }
                    else
                    {
                        bookDetails.Add(isbnTextBox.Text, nameTextBox.Text);
                        informationListBox.Items.Add(isbnTextBox.Text);
                        informationListBox.Items.Add(nameTextBox.Text);
                        clear();
                        isbnTextBox.Focus();
                    }
                    
                }

            }
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
             searchListBox.Items.Clear();
             if (isbnRadioButton.Checked == true)
             {
                 Dictionary<string, string>.KeyCollection keyColl = bookDetails.Keys;
                 string isbn = searchTextBox.Text;
                 if (string.IsNullOrEmpty(searchTextBox.Text))
                 {
                     MessageBox.Show("Please insert");
                 }
                 else
                 {
                     if (keyColl.Contains(isbn))
                     {
                         searchListBox.Items.Add(bookDetails[isbn]);
                         searchTextBox.Clear();
                     }
                     else
                     {
                         MessageBox.Show("items not matched");
                     }
                 }
                
 
             }

             else if(nameRadioButton.Checked == true)
             {

                 //Dictionary<string, string>.ValueCollection valueColl = bookDetails.Values;
                
                 string bookName = Convert.ToString(searchTextBox.Text.ToLower());
                 if (string.IsNullOrEmpty(searchTextBox.Text))
                 {
                     MessageBox.Show("Please insert");
                 }
                 else 
                 {
                     foreach(string data in bookDetails.Values)
                     {
                         string name = data.ToLower();
                         if (name.Contains(bookName))
                         {
                             searchListBox.Items.Add(data);
                             searchTextBox.Clear();
                             break;
                         }
                         else
                         {
                             MessageBox.Show("dont matched");
                             break;
                         }
                         
                     }
                     
                 }
                 
             }
             else
             {
                 MessageBox.Show("invalid");
             }
             
        }

        private void BookInformationForm_Load(object sender, EventArgs e)
        {
            isbnRadioButton.Checked = true;
        }

    }
}
