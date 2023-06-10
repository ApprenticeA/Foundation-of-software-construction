using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ConfirmAdd_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(OrderID.Text);
            string customer = ClientName.Text;
            string date=OrderDate.Text;
            string name=GoodsName.Text;
            int amount=int.Parse(GoodsAmount.Text);
            double price = double.Parse(GoodsPrice.Text);
            OperateForm.orderservice.add(new Order(ID,customer,date,new OrderDetails(name,amount,price)));
            Response responseForm = new Response();
            responseForm.ShowDialog();
        }

        private void OrderID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
