using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtherControlsApp
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void MainUi_Load(object sender, EventArgs e)
        {
            LoadCountryComboBox();
            //showCountryLabel.Text = "";
            checkBox2.Checked = true; 
        }

        private void LoadCountryComboBox()
        {
            countryComboBox.Items.Add("Bangladesh");
            countryComboBox.Items.Add("India");
            countryComboBox.Items.Add("Pakistan");
            countryComboBox.Items.Add("Srilanka");
            countryComboBox.Items.Add("Nepal");

        }

        private void countryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string coutnry = countryComboBox.Text;
            showCountryLabel.Text =coutnry;
        }

        private void checkAllButton_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                checkAllButton.Text = "Check All";
            }
            else
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;

                checkAllButton.Text = "Uncheck All";
            }

            
        }
    }
}
