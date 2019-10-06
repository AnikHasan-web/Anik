namespace EmailKeeperUIApp
{
    partial class EmailKeeperForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmailTextBox = new System.Windows.Forms.TextBox();
            this.searchEmailTextBox = new System.Windows.Forms.TextBox();
            this.addEmailButton = new System.Windows.Forms.Button();
            this.searchEmailButton = new System.Windows.Forms.Button();
            this.addEmailListBox = new System.Windows.Forms.ListBox();
            this.searchEmailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email to add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email to search";
            // 
            // addEmailTextBox
            // 
            this.addEmailTextBox.Location = new System.Drawing.Point(104, 50);
            this.addEmailTextBox.Name = "addEmailTextBox";
            this.addEmailTextBox.Size = new System.Drawing.Size(152, 20);
            this.addEmailTextBox.TabIndex = 2;
            // 
            // searchEmailTextBox
            // 
            this.searchEmailTextBox.Location = new System.Drawing.Point(375, 50);
            this.searchEmailTextBox.Name = "searchEmailTextBox";
            this.searchEmailTextBox.Size = new System.Drawing.Size(152, 20);
            this.searchEmailTextBox.TabIndex = 3;
            // 
            // addEmailButton
            // 
            this.addEmailButton.Location = new System.Drawing.Point(181, 96);
            this.addEmailButton.Name = "addEmailButton";
            this.addEmailButton.Size = new System.Drawing.Size(75, 23);
            this.addEmailButton.TabIndex = 4;
            this.addEmailButton.Text = "Add";
            this.addEmailButton.UseVisualStyleBackColor = true;
            this.addEmailButton.Click += new System.EventHandler(this.addEmailButton_Click);
            // 
            // searchEmailButton
            // 
            this.searchEmailButton.Location = new System.Drawing.Point(452, 93);
            this.searchEmailButton.Name = "searchEmailButton";
            this.searchEmailButton.Size = new System.Drawing.Size(75, 23);
            this.searchEmailButton.TabIndex = 4;
            this.searchEmailButton.Text = "Search";
            this.searchEmailButton.UseVisualStyleBackColor = true;
            this.searchEmailButton.Click += new System.EventHandler(this.searchEmailButton_Click);
            // 
            // addEmailListBox
            // 
            this.addEmailListBox.FormattingEnabled = true;
            this.addEmailListBox.Location = new System.Drawing.Point(104, 144);
            this.addEmailListBox.Name = "addEmailListBox";
            this.addEmailListBox.Size = new System.Drawing.Size(152, 160);
            this.addEmailListBox.TabIndex = 5;
            // 
            // searchEmailListBox
            // 
            this.searchEmailListBox.FormattingEnabled = true;
            this.searchEmailListBox.Location = new System.Drawing.Point(375, 141);
            this.searchEmailListBox.Name = "searchEmailListBox";
            this.searchEmailListBox.Size = new System.Drawing.Size(152, 160);
            this.searchEmailListBox.TabIndex = 5;
            // 
            // EmailKeeperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 327);
            this.Controls.Add(this.searchEmailListBox);
            this.Controls.Add(this.addEmailListBox);
            this.Controls.Add(this.searchEmailButton);
            this.Controls.Add(this.addEmailButton);
            this.Controls.Add(this.searchEmailTextBox);
            this.Controls.Add(this.addEmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmailKeeperForm";
            this.Text = "Email Keeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmailTextBox;
        private System.Windows.Forms.TextBox searchEmailTextBox;
        private System.Windows.Forms.Button addEmailButton;
        private System.Windows.Forms.Button searchEmailButton;
        private System.Windows.Forms.ListBox addEmailListBox;
        private System.Windows.Forms.ListBox searchEmailListBox;
    }
}

