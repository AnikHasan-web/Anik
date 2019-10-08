namespace ticket_resevation
{
    partial class PurchaseTicketUi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numberOfTicketsTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.priceButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.detailsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // numberOfTicketsTextBox
            // 
            this.numberOfTicketsTextBox.Location = new System.Drawing.Point(279, 12);
            this.numberOfTicketsTextBox.Name = "numberOfTicketsTextBox";
            this.numberOfTicketsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfTicketsTextBox.TabIndex = 0;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(279, 49);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.unitPriceTextBox.TabIndex = 1;
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(279, 87);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Unit Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer Name";
            // 
            // priceButton
            // 
            this.priceButton.Location = new System.Drawing.Point(303, 114);
            this.priceButton.Name = "priceButton";
            this.priceButton.Size = new System.Drawing.Size(75, 23);
            this.priceButton.TabIndex = 6;
            this.priceButton.Text = "Price";
            this.priceButton.UseVisualStyleBackColor = true;
            this.priceButton.Click += new System.EventHandler(this.priceButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.Location = new System.Drawing.Point(303, 143);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(75, 23);
            this.detailsButton.TabIndex = 7;
            this.detailsButton.Text = "Details";
            this.detailsButton.UseVisualStyleBackColor = true;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // detailsListBox
            // 
            this.detailsListBox.FormattingEnabled = true;
            this.detailsListBox.Location = new System.Drawing.Point(28, 190);
            this.detailsListBox.Name = "detailsListBox";
            this.detailsListBox.Size = new System.Drawing.Size(348, 95);
            this.detailsListBox.TabIndex = 8;
            // 
            // PurchaseTicketUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 361);
            this.Controls.Add(this.detailsListBox);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.priceButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.unitPriceTextBox);
            this.Controls.Add(this.numberOfTicketsTextBox);
            this.Name = "PurchaseTicketUi";
            this.Text = "Ticket Reservation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberOfTicketsTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button priceButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.ListBox detailsListBox;
    }
}

