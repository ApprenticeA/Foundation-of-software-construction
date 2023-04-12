namespace WinFormsjisuanqi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            num1TextBox = new TextBox();
            num2TextBox = new TextBox();
            resultLabel = new Label();
            calculateButton = new Button();
            operatorComboBox = new ComboBox();
            SuspendLayout();
            // 
            // num1TextBox
            // 
            num1TextBox.Location = new Point(71, 178);
            num1TextBox.Name = "num1TextBox";
            num1TextBox.Size = new Size(100, 23);
            num1TextBox.TabIndex = 0;
            // 
            // num2TextBox
            // 
            num2TextBox.Location = new Point(347, 178);
            num2TextBox.Name = "num2TextBox";
            num2TextBox.Size = new Size(100, 23);
            num2TextBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.BackColor = SystemColors.ButtonHighlight;
            resultLabel.Location = new Point(537, 184);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(40, 17);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "result";
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(537, 284);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "计算";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // operatorComboBox
            // 
            operatorComboBox.DropDownHeight = 120;
            operatorComboBox.FormattingEnabled = true;
            operatorComboBox.IntegralHeight = false;
            operatorComboBox.Items.AddRange(new object[] { "+", "-", "*", "/" });
            operatorComboBox.Location = new Point(199, 178);
            operatorComboBox.Name = "operatorComboBox";
            operatorComboBox.Size = new Size(121, 25);
            operatorComboBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(operatorComboBox);
            Controls.Add(calculateButton);
            Controls.Add(resultLabel);
            Controls.Add(num2TextBox);
            Controls.Add(num1TextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox num1TextBox;
        private TextBox num2TextBox;
        private Label resultLabel;
        private Button calculateButton;
        private ComboBox operatorComboBox;

    }
}