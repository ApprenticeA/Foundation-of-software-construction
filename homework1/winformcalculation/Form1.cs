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
            // ���ı����л�ȡ��������
            double num1 = double.Parse(num1TextBox.Text);
            double num2 = double.Parse(num2TextBox.Text);

            // �������б���л�ȡѡ��������
            string op = operatorComboBox.SelectedItem.ToString();

            // ִ������ļ���
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

            // ����������ʾ�ڱ�ǩ��
            resultLabel.Text = result.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}