namespace PresidentialEligibility_PartC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NaturalBornCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthYearTextBox = new System.Windows.Forms.RichTextBox();
            this.yearsResidedTextBox = new System.Windows.Forms.RichTextBox();
            this.priortermsTextBox = new System.Windows.Forms.RichTextBox();
            this.checkRebel = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NaturalBornCheckBox
            // 
            this.NaturalBornCheckBox.AutoSize = true;
            this.NaturalBornCheckBox.Location = new System.Drawing.Point(15, 21);
            this.NaturalBornCheckBox.Name = "NaturalBornCheckBox";
            this.NaturalBornCheckBox.Size = new System.Drawing.Size(119, 17);
            this.NaturalBornCheckBox.TabIndex = 0;
            this.NaturalBornCheckBox.Text = "Natural Born Citizen";
            this.NaturalBornCheckBox.UseVisualStyleBackColor = true;
            this.NaturalBornCheckBox.CheckedChanged += new System.EventHandler(this.NaturalBornCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is your birth year?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "How many years have you resided in the U.S.?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "How many prior terms have you served?";
            // 
            // BirthYearTextBox
            // 
            this.BirthYearTextBox.Location = new System.Drawing.Point(246, 50);
            this.BirthYearTextBox.Name = "BirthYearTextBox";
            this.BirthYearTextBox.Size = new System.Drawing.Size(100, 22);
            this.BirthYearTextBox.TabIndex = 4;
            this.BirthYearTextBox.Text = "";
            // 
            // yearsResidedTextBox
            // 
            this.yearsResidedTextBox.Location = new System.Drawing.Point(246, 84);
            this.yearsResidedTextBox.Name = "yearsResidedTextBox";
            this.yearsResidedTextBox.Size = new System.Drawing.Size(100, 21);
            this.yearsResidedTextBox.TabIndex = 5;
            this.yearsResidedTextBox.Text = "";
            // 
            // priortermsTextBox
            // 
            this.priortermsTextBox.Location = new System.Drawing.Point(246, 124);
            this.priortermsTextBox.Name = "priortermsTextBox";
            this.priortermsTextBox.Size = new System.Drawing.Size(100, 22);
            this.priortermsTextBox.TabIndex = 6;
            this.priortermsTextBox.Text = "";
            // 
            // checkRebel
            // 
            this.checkRebel.AutoSize = true;
            this.checkRebel.Location = new System.Drawing.Point(15, 163);
            this.checkRebel.Name = "checkRebel";
            this.checkRebel.Size = new System.Drawing.Size(142, 17);
            this.checkRebel.TabIndex = 7;
            this.checkRebel.Text = "rebelled against the U.S.";
            this.checkRebel.UseVisualStyleBackColor = true;
            this.checkRebel.CheckedChanged += new System.EventHandler(this.checkRebel_CheckedChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(165, 218);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 36);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Determine Eligibility";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 294);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.checkRebel);
            this.Controls.Add(this.priortermsTextBox);
            this.Controls.Add(this.yearsResidedTextBox);
            this.Controls.Add(this.BirthYearTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NaturalBornCheckBox);
            this.Name = "Form1";
            this.Text = "Presidential Eligibility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox NaturalBornCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox BirthYearTextBox;
        private System.Windows.Forms.RichTextBox yearsResidedTextBox;
        private System.Windows.Forms.RichTextBox priortermsTextBox;
        private System.Windows.Forms.CheckBox checkRebel;
        private System.Windows.Forms.Button submitButton;
    }
}

