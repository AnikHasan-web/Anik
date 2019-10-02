using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day_5
{
    public partial class NameForm : Form
    {
        private List<string> namelist = new List<string>();

            
          
        public NameForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            namelist.Add(nameTextBox.Text);
            CLear();

        }


        private void CLear()
        {
            nameTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            foreach (string name in namelist)
            {
                nameListBox.Items.Add(name);
            }

            countTextBox.Text = Convert.ToString(namelist.Count());
        }
       
    }
}
