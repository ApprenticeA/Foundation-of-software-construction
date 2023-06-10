using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    public class OrderService    //所有订单
    {
        public List<Order> orders = new List<Order>();
        public OrderService() { }

        //增加订单
        public void add(Order order)         
        {
            if (orders.Contains(order))
            {
                //异常后执行的代码
            }
             order.getSum();
             orders.Add(order);
        }
        //删除订单
        public void remove(int id)           
        {
                int index = 0;
                foreach (Order temp in this.orders)
                {
                    if (temp.ID == id) index = this.orders.IndexOf(temp);
                }
                this.orders.RemoveAt(index);
        }

        //更新订单
        public void Update(int id, Order order)
        {
            int idx = orders.FindIndex(o => o.ID == id);
            orders.RemoveAt(idx);
            orders.Add(order);
        }

        //查询订单
        public List<Order> SelectAll()//查询所有订单
        {
            return orders;
        }
        public List<Order> SearchByCustomerName(string customer)//根据客户名查询订单
        {
            var query = from o in orders
                        where o.Customer == customer
                        orderby o.Sum
                        select o;
            return query.ToList();
        }
        public List<Order> SearchByOrderID(int order_id)//根据订单号查询订单
        {
            var query = from o in orders
                        where o.ID == order_id
                        orderby o.Sum
                        select o;
            return query.ToList();
        }

        public List<Order> SearchByDate(string date)//根据交易日期查询订单
        {
            var query = from o in orders
                        where o.Date == date
                        orderby o.Sum
                        select o;
            return query.ToList();
        }
        public List<Order> SelectBySumPrice(double sum)//根据总量查询订单
        {
            var query = from o in orders
                        where o.Sum == sum
                        select o;
            return query.ToList();
        }
    }
}
