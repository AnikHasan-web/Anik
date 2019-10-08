using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string,string> _aDictionary = new Dictionary<string, string>(); 
        


        private void clear()
        {
            idTextBox.Clear();
            searchTextBox.Clear();
            detailsTextBox.Clear();
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            _aDictionary.Add(idTextBox.Text,detailsTextBox.Text);
            MessageBox.Show("Data Saved");
            clear();
            idTextBox.Focus();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (_aDictionary.ContainsKey(searchTextBox.Text))
            {
                MessageBox.Show(searchTextBox.Text + " | " + _aDictionary[searchTextBox.Text]);
            }
            else
            {
                MessageBox.Show("Key dose not exit");
            }
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            string message = String.Empty;
            foreach (KeyValuePair<string, string> pair in _aDictionary)
            {
                message = message + pair.Key + " | " + pair.Value + "\n";
            }
            MessageBox.Show(message);
        }
    }
}
