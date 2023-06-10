using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class Order //一个订单
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public double Sum { get; set; }
        public string Date { get; set; }
        public OrderDetails orderDetail;
        public Order() { }
        public Order(int id, string customer, string date,OrderDetails orderdetail)
        {
            this.ID = id;
            this.Customer = customer;
            this.Date = date;
            this.orderDetail = orderdetail;
        }

        //利用订单号判断两个订单是否相同
        //重写equals函数，利用主码ID判断订单号是否重复
        public override bool Equals(object obj)
        {
            Order order = obj as Order;
            return this.ID == order.ID;
        }
        public override int GetHashCode()
        {
            return Convert.ToInt32(ID);
        }

        //该订单的总金额
        public void getSum()
        {
            this.Sum = orderDetail.totalPrice();
        }
    }
}
