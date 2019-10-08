using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_entry
{
    
    public partial class Form1 : Form
    {
        private List<int> numberlist = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int numbers = Convert.ToInt32(numberTextBox.Text);
            numberlist.Add(numbers);
            
            numberTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(int num in numberlist)
            {
                numberListBox.Items.Add(num);
                sum = sum + num;
            }
            resultTextBox.Text = Convert.ToString(sum);
        }
    }
}
