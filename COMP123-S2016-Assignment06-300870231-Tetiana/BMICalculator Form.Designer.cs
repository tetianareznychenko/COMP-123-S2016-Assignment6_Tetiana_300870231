namespace COMP123_S2016_Assignment06_300870231_Tetiana
{
    partial class BMICalculatorForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.InchesRadioButton = new System.Windows.Forms.RadioButton();
            this.MetresRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.PoundsRadioButton = new System.Windows.Forms.RadioButton();
            this.KilogramsRadioButton = new System.Windows.Forms.RadioButton();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.BMICalculatorButton = new System.Windows.Forms.Button();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(58, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(185, 48);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Enter the data\r\nand choose units";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(12, 86);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(115, 24);
            this.HeightLabel.TabIndex = 1;
            this.HeightLabel.Text = "My Height";
            // 
            // InchesRadioButton
            // 
            this.InchesRadioButton.AutoSize = true;
            this.InchesRadioButton.Location = new System.Drawing.Point(12, 123);
            this.InchesRadioButton.Name = "InchesRadioButton";
            this.InchesRadioButton.Size = new System.Drawing.Size(93, 28);
            this.InchesRadioButton.TabIndex = 2;
            this.InchesRadioButton.TabStop = true;
            this.InchesRadioButton.Text = "inches";
            this.InchesRadioButton.UseVisualStyleBackColor = true;
            // 
            // MetresRadioButton
            // 
            this.MetresRadioButton.AutoSize = true;
            this.MetresRadioButton.Location = new System.Drawing.Point(133, 123);
            this.MetresRadioButton.Name = "MetresRadioButton";
            this.MetresRadioButton.Size = new System.Drawing.Size(100, 28);
            this.MetresRadioButton.TabIndex = 3;
            this.MetresRadioButton.TabStop = true;
            this.MetresRadioButton.Text = "metres";
            this.MetresRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(12, 169);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(231, 32);
            this.HeightTextBox.TabIndex = 4;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(12, 217);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(118, 24);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "My Weight";
            // 
            // PoundsRadioButton
            // 
            this.PoundsRadioButton.AutoSize = true;
            this.PoundsRadioButton.Location = new System.Drawing.Point(12, 258);
            this.PoundsRadioButton.Name = "PoundsRadioButton";
            this.PoundsRadioButton.Size = new System.Drawing.Size(103, 28);
            this.PoundsRadioButton.TabIndex = 6;
            this.PoundsRadioButton.TabStop = true;
            this.PoundsRadioButton.Text = "pounds";
            this.PoundsRadioButton.UseVisualStyleBackColor = true;
            // 
            // KilogramsRadioButton
            // 
            this.KilogramsRadioButton.AutoSize = true;
            this.KilogramsRadioButton.Location = new System.Drawing.Point(133, 258);
            this.KilogramsRadioButton.Name = "KilogramsRadioButton";
            this.KilogramsRadioButton.Size = new System.Drawing.Size(129, 28);
            this.KilogramsRadioButton.TabIndex = 7;
            this.KilogramsRadioButton.TabStop = true;
            this.KilogramsRadioButton.Text = "kilograms";
            this.KilogramsRadioButton.UseVisualStyleBackColor = true;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(12, 303);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(231, 32);
            this.WeightTextBox.TabIndex = 8;
            // 
            // BMICalculatorButton
            // 
            this.BMICalculatorButton.Location = new System.Drawing.Point(16, 353);
            this.BMICalculatorButton.Name = "BMICalculatorButton";
            this.BMICalculatorButton.Size = new System.Drawing.Size(227, 38);
            this.BMICalculatorButton.TabIndex = 9;
            this.BMICalculatorButton.Text = "Calculate BMI";
            this.BMICalculatorButton.UseVisualStyleBackColor = true;
            // 
            // BMITextBox
            // 
            this.BMITextBox.Location = new System.Drawing.Point(12, 397);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.Size = new System.Drawing.Size(280, 32);
            this.BMITextBox.TabIndex = 10;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.BMICalculatorButton);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.KilogramsRadioButton);
            this.Controls.Add(this.PoundsRadioButton);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.MetresRadioButton);
            this.Controls.Add(this.InchesRadioButton);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.RadioButton InchesRadioButton;
        private System.Windows.Forms.RadioButton MetresRadioButton;
        public System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.RadioButton PoundsRadioButton;
        private System.Windows.Forms.RadioButton KilogramsRadioButton;
        public System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button BMICalculatorButton;
        public System.Windows.Forms.TextBox BMITextBox;
    }
}

