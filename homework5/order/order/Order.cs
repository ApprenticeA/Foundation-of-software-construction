using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement
{
    class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public double TotalAmount => OrderDetails.Sum(d => d.Amount);

        public Order(int orderId, Customer customer)
        {
            OrderId = orderId;
            Customer = customer;
            OrderDetails = new List<OrderDetail>();
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            return order != null && OrderId == order.OrderId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderId);
        }

        public override string ToString()
        {
            return $"OrderId:{OrderId}, Customer:{Customer}, TotalAmount:{TotalAmount}";
        }
    }
}
