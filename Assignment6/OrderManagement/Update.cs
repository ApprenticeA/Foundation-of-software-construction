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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void ConfirmUpdate_Click(object sender, EventArgs e)
        {
            int IDB = int.Parse(IDBefore.Text);
            int ID = int.Parse(OrderID.Text);
            string customer = Customer.Text;
            string date = OrderDate.Text;
            string name = GoodsName.Text;
            int amount = int.Parse(GoodsAmount.Text);
            double price = double.Parse(GoodsPrice.Text);
            OperateForm.orderservice.Update(IDB,new Order(ID,customer,date,new OrderDetails(name,amount,price)));

        }
    }
}
