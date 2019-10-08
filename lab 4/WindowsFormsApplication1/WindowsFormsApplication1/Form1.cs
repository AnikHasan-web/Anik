using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class nameForm : Form
    {
        public nameForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string name=firstNameTextBox.Text;
            MessageBox.Show("Hi "+name+" Welcome to our world");
        }
    }
}
