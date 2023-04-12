using System;
using System.Windows.Forms;

namespace WinFormsjisuanqi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 从文本框中获取输入数字
            double num1 = double.Parse(num1TextBox.Text);
            double num2 = double.Parse(num2TextBox.Text);

            // 从下拉列表框中获取选择的运算符
            string op = operatorComboBox.SelectedItem.ToString();

            // 执行所需的计算
            double result = 0;
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            // 将计算结果显示在标签中
            resultLabel.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}