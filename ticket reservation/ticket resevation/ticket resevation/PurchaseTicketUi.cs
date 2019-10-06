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

namespace ticket_resevation
{
    public partial class PurchaseTicketUi : Form
    {
        public PurchaseTicketUi()
        {
            InitializeComponent();
        }
        private int numberOfTickets = 0;
        private double unitPrice = 0;
        private string customerName = "";
        private double totalPrice = 0;
        ArrayList details = new ArrayList(); 
        private void priceButton_Click(object sender, EventArgs e)
        {
            numberOfTickets = Convert.ToInt16(numberOfTicketsTextBox.Text);
            details.Add("Number of Tickets: " + numberOfTicketsTextBox.Text);
            
            unitPrice = Convert.ToInt16(unitPriceTextBox.Text);
            details.Add("unit Price: " + unitPriceTextBox.Text +" Taka");
            
            customerName = customerNameTextBox.Text;
            details.Add("Customer Name: " + customerNameTextBox.Text);

            totalPrice = unitPrice * numberOfTickets;
            details.Add("total Price: " + totalPrice);
            MessageBox.Show(customerName + ", Please Pay " + totalPrice + " Taka to Purchase " + numberOfTickets + " Ticket(s) "+" Where each ticket price is "+unitPrice+" Taka");

        }

        private void detailsButton_Click(object sender, EventArgs e)
        {
            foreach(var items in details)
            {
                detailsListBox.Items.Add(items);
            }  
        }
    }
}
