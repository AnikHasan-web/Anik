namespace simple_Interest_Calculator
{
    partial class CalculatorForm
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
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.equationComboBox = new System.Windows.Forms.ComboBox();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.solveLabel = new System.Windows.Forms.Label();
            this.whereLabel = new System.Windows.Forms.Label();
            this.showEquationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.sicLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox1
            // 
            this.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox1.Location = new System.Drawing.Point(311, 122);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(100, 20);
            this.TextBox1.TabIndex = 1;
            // 
            // TextBox2
            // 
            this.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox2.Location = new System.Drawing.Point(311, 153);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(100, 20);
            this.TextBox2.TabIndex = 2;
            // 
            // TextBox3
            // 
            this.TextBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox3.Location = new System.Drawing.Point(311, 201);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(100, 20);
            this.TextBox3.TabIndex = 3;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(133, 283);
            this.answerTextBox.Multiline = true;
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(278, 45);
            this.answerTextBox.TabIndex = 0;
            this.answerTextBox.Text = "Answer:\r\n                                         A=?";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(133, 254);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(336, 254);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // equationComboBox
            // 
            this.equationComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.equationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equationComboBox.FormattingEnabled = true;
            this.equationComboBox.Location = new System.Drawing.Point(311, 57);
            this.equationComboBox.Name = "equationComboBox";
            this.equationComboBox.Size = new System.Drawing.Size(121, 21);
            this.equationComboBox.TabIndex = 0;
            this.equationComboBox.SelectedIndexChanged += new System.EventHandler(this.equationComboBox_SelectedIndexChanged);
            // 
            // timeComboBox
            // 
            this.timeComboBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(290, 220);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(121, 21);
            this.timeComboBox.TabIndex = 4;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.timeComboBox_SelectedIndexChanged);
            // 
            // solveLabel
            // 
            this.solveLabel.AutoSize = true;
            this.solveLabel.Location = new System.Drawing.Point(250, 60);
            this.solveLabel.Name = "solveLabel";
            this.solveLabel.Size = new System.Drawing.Size(55, 13);
            this.solveLabel.TabIndex = 5;
            this.solveLabel.Text = "Solve For:";
            // 
            // whereLabel
            // 
            this.whereLabel.AutoSize = true;
            this.whereLabel.Location = new System.Drawing.Point(263, 81);
            this.whereLabel.Name = "whereLabel";
            this.whereLabel.Size = new System.Drawing.Size(42, 13);
            this.whereLabel.TabIndex = 6;
            this.whereLabel.Text = "Where:";
            // 
            // showEquationLabel
            // 
            this.showEquationLabel.AutoSize = true;
            this.showEquationLabel.Location = new System.Drawing.Point(311, 81);
            this.showEquationLabel.Name = "showEquationLabel";
            this.showEquationLabel.Size = new System.Drawing.Size(49, 13);
            this.showEquationLabel.TabIndex = 7;
            this.showEquationLabel.Text = "Equation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(238, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(228, 204);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "label3";
            // 
            // sicLabel
            // 
            this.sicLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sicLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sicLabel.Location = new System.Drawing.Point(152, 9);
            this.sicLabel.Name = "sicLabel";
            this.sicLabel.Size = new System.Drawing.Size(357, 32);
            this.sicLabel.TabIndex = 12;
            this.sicLabel.Text = "Simple Interest Calculator";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(663, 343);
            this.Controls.Add(this.sicLabel);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showEquationLabel);
            this.Controls.Add(this.whereLabel);
            this.Controls.Add(this.solveLabel);
            this.Controls.Add(this.timeComboBox);
            this.Controls.Add(this.equationComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Interest Calculator";
            this.Load += new System.EventHandler(this.CalculatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.TextBox TextBox2;
        private System.Windows.Forms.TextBox TextBox3;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox equationComboBox;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label solveLabel;
        private System.Windows.Forms.Label whereLabel;
        private System.Windows.Forms.Label showEquationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label sicLabel;
    }
}

