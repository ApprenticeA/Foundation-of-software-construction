using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class OrderDetails               //订单明细项
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public OrderDetails()//无参构造函数
        {
            this.Name = string.Empty;
            this.Amount = 0;
            this.Price = 0;
        }
        public OrderDetails(string name, int number, double price)
        {
            this.Name = name;
            this.Amount = number;
            this.Price = price;
        }
        public double totalPrice()
        {
            return this.Amount * this.Price;
        }
    }
}
