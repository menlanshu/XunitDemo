namespace WinFormUI
{
    partial class Dashboard
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
            this.calcSectionGB = new System.Windows.Forms.GroupBox();
            this.dataBaseSectionGB = new System.Windows.Forms.GroupBox();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumberLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.secondNameLable = new System.Windows.Forms.Label();
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.mulitiplyButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.firstNumberUD = new System.Windows.Forms.NumericUpDown();
            this.secondNumberUD = new System.Windows.Forms.NumericUpDown();
            this.calcSectionGB.SuspendLayout();
            this.dataBaseSectionGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberUD)).BeginInit();
            this.SuspendLayout();
            // 
            // calcSectionGB
            // 
            this.calcSectionGB.Controls.Add(this.secondNumberUD);
            this.calcSectionGB.Controls.Add(this.firstNumberUD);
            this.calcSectionGB.Controls.Add(this.divideButton);
            this.calcSectionGB.Controls.Add(this.mulitiplyButton);
            this.calcSectionGB.Controls.Add(this.substractButton);
            this.calcSectionGB.Controls.Add(this.addButton);
            this.calcSectionGB.Controls.Add(this.resultTextBox);
            this.calcSectionGB.Controls.Add(this.resultLabel);
            this.calcSectionGB.Controls.Add(this.secondNumberLabel);
            this.calcSectionGB.Controls.Add(this.firstNumberLabel);
            this.calcSectionGB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcSectionGB.Location = new System.Drawing.Point(52, 46);
            this.calcSectionGB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.calcSectionGB.Name = "calcSectionGB";
            this.calcSectionGB.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.calcSectionGB.Size = new System.Drawing.Size(529, 569);
            this.calcSectionGB.TabIndex = 0;
            this.calcSectionGB.TabStop = false;
            this.calcSectionGB.Text = "Calcuate Section";
            // 
            // dataBaseSectionGB
            // 
            this.dataBaseSectionGB.Controls.Add(this.addPersonButton);
            this.dataBaseSectionGB.Controls.Add(this.secondNameTextBox);
            this.dataBaseSectionGB.Controls.Add(this.firstNameTextBox);
            this.dataBaseSectionGB.Controls.Add(this.userComboBox);
            this.dataBaseSectionGB.Controls.Add(this.secondNameLable);
            this.dataBaseSectionGB.Controls.Add(this.firstNameLabel);
            this.dataBaseSectionGB.Controls.Add(this.userLabel);
            this.dataBaseSectionGB.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBaseSectionGB.Location = new System.Drawing.Point(636, 46);
            this.dataBaseSectionGB.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dataBaseSectionGB.Name = "dataBaseSectionGB";
            this.dataBaseSectionGB.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.dataBaseSectionGB.Size = new System.Drawing.Size(543, 569);
            this.dataBaseSectionGB.TabIndex = 1;
            this.dataBaseSectionGB.TabStop = false;
            this.dataBaseSectionGB.Text = "Database Section";
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Location = new System.Drawing.Point(27, 58);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(133, 30);
            this.firstNumberLabel.TabIndex = 0;
            this.firstNumberLabel.Text = "First Number";
            // 
            // secondNumberLabel
            // 
            this.secondNumberLabel.AutoSize = true;
            this.secondNumberLabel.Location = new System.Drawing.Point(27, 127);
            this.secondNumberLabel.Name = "secondNumberLabel";
            this.secondNumberLabel.Size = new System.Drawing.Size(163, 30);
            this.secondNumberLabel.TabIndex = 1;
            this.secondNumberLabel.Text = "Second Number";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(230, 269);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(78, 30);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "Results";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(28, 80);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(63, 30);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Users";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(28, 163);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            // 
            // secondNameLable
            // 
            this.secondNameLable.AutoSize = true;
            this.secondNameLable.Location = new System.Drawing.Point(28, 220);
            this.secondNameLable.Name = "secondNameLable";
            this.secondNameLable.Size = new System.Drawing.Size(112, 30);
            this.secondNameLable.TabIndex = 5;
            this.secondNameLable.Text = "Last Name";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(129, 77);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(305, 38);
            this.userComboBox.TabIndex = 6;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(161, 163);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(256, 35);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Location = new System.Drawing.Point(161, 220);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(256, 35);
            this.secondNameTextBox.TabIndex = 8;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(235, 309);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(222, 35);
            this.resultTextBox.TabIndex = 8;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(32, 220);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(121, 45);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.Location = new System.Drawing.Point(32, 269);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(121, 45);
            this.substractButton.TabIndex = 10;
            this.substractButton.Text = "Substract";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // mulitiplyButton
            // 
            this.mulitiplyButton.Location = new System.Drawing.Point(32, 320);
            this.mulitiplyButton.Name = "mulitiplyButton";
            this.mulitiplyButton.Size = new System.Drawing.Size(121, 45);
            this.mulitiplyButton.TabIndex = 11;
            this.mulitiplyButton.Text = "Multiply";
            this.mulitiplyButton.UseVisualStyleBackColor = true;
            this.mulitiplyButton.Click += new System.EventHandler(this.mulitiplyButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(32, 371);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(121, 45);
            this.divideButton.TabIndex = 12;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(129, 290);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(232, 45);
            this.addPersonButton.TabIndex = 13;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // firstNumberUD
            // 
            this.firstNumberUD.Location = new System.Drawing.Point(197, 56);
            this.firstNumberUD.Name = "firstNumberUD";
            this.firstNumberUD.Size = new System.Drawing.Size(120, 35);
            this.firstNumberUD.TabIndex = 13;
            // 
            // secondNumberUD
            // 
            this.secondNumberUD.Location = new System.Drawing.Point(197, 122);
            this.secondNumberUD.Name = "secondNumberUD";
            this.secondNumberUD.Size = new System.Drawing.Size(120, 35);
            this.secondNumberUD.TabIndex = 14;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 715);
            this.Controls.Add(this.dataBaseSectionGB);
            this.Controls.Add(this.calcSectionGB);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Dashboard";
            this.Text = "Demo Dashboard by Fu Long";
            this.calcSectionGB.ResumeLayout(false);
            this.calcSectionGB.PerformLayout();
            this.dataBaseSectionGB.ResumeLayout(false);
            this.dataBaseSectionGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumberUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumberUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calcSectionGB;
        private System.Windows.Forms.NumericUpDown secondNumberUD;
        private System.Windows.Forms.NumericUpDown firstNumberUD;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button mulitiplyButton;
        private System.Windows.Forms.Button substractButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label secondNumberLabel;
        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.GroupBox dataBaseSectionGB;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label secondNameLable;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label userLabel;
    }
}

