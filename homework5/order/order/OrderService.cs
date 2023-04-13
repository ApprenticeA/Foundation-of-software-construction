using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement
{
    class OrderService
    {
        private List<Order> orderList = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orderList.Contains(order))
            {
                throw new Exception($"Order-{order.OrderId} is already existed!");
            }
            orderList.Add(order);
        }

        public void RemoveOrder(int orderId)
        {
            var order = GetOrderById(orderId);
            if (order == null)
            {
                throw new Exception($"Order-{orderId} is not existed!");
            }
            orderList.Remove(order);
        }

        public void UpdateOrder(Order newOrder)
        {
            var oldOrder = GetOrderById(newOrder.OrderId);
            if (oldOrder == null)
            {
                throw new Exception($"Order-{newOrder.OrderId} is not existed!");
            }
            orderList.Remove(oldOrder);
            orderList.Add(newOrder);
        }

        public Order GetOrderById(int orderId)
        {
            return orderList.FirstOrDefault(o => o.OrderId == orderId);
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            var query = orderList.Where(
                o => o.OrderDetails.Exists(
                    d => d.Goods.Name.Equals(goodsName)));
            return query.ToList();
        }

        public List<Order> QueryOrdersByCustomerName(string customerName)
        {
            var query = orderList.Where(
                o => o.Customer.Name.Equals(customerName));
            return query.ToList();
        }

        public List<Order> QueryOrdersByTotalAmount(double totalAmount)
        {
            var query = orderList.Where(o => o.TotalAmount == totalAmount);
            return query.ToList();
        }

        public List<Order> QueryAllOrders()
        {
            return orderList.OrderBy(o => o.OrderId).ToList();
        }

        public void Sort(Comparison<Order> comparison)
        {
            orderList.Sort(comparison);
        }

        public void Sort()
        {
            orderList.Sort((o1, o2) => o1.OrderId.CompareTo(o2.OrderId));
        }

        private int NextId()
        {
            return orderList.Count + 1;
        }
    }
}


