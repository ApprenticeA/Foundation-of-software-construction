using OrderManagement;
using System;
using System.Collections.Generic;
using System.Linq;

Customer customer1 = new Customer(1, "Alice");
Customer customer2 = new Customer(2, "Bob");
Goods goods1 = new Goods(1, "Apple", 5.0);
Goods goods2 = new Goods(2, "Banana", 4.0);
Goods goods3 = new Goods(3, "Cherry", 6.0);
OrderDetail orderDetail1 = new OrderDetail(1, goods1, 10);
OrderDetail orderDetail2 = new OrderDetail(2, goods2, 20);
OrderDetail orderDetail3 = new OrderDetail(3, goods3, 30);
Order order1 = new Order(1, customer1);
order1.OrderDetails.Add(orderDetail1);
order1.OrderDetails.Add(orderDetail2);
Order order2 = new Order(2, customer2);
order2.OrderDetails.Add(orderDetail2);
order2.OrderDetails.Add(orderDetail3);
OrderService orderService = new OrderService();
orderService.AddOrder(order1);
orderService.AddOrder(order2);

// 测试添加订单
Console.WriteLine("Test AddOrder:");
Order order3 = new Order(3, customer1);
order3.OrderDetails.Add(orderDetail1);
order3.OrderDetails.Add(orderDetail3);
orderService.AddOrder(order3);
List<Order> allOrders = orderService.QueryAllOrders();
foreach (Order order in allOrders)
{
    Console.WriteLine(order);
}
Console.WriteLine();

// 测试删除订单
Console.WriteLine("Test RemoveOrder:");
try
{
    orderService.RemoveOrder(4);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
orderService.RemoveOrder(2);
allOrders = orderService.QueryAllOrders();
foreach (Order order in allOrders)
{
    Console.WriteLine(order);
}
Console.WriteLine();

// 测试修改订单
Console.WriteLine("Test UpdateOrder:");
Order order4 = new Order(3, customer2);
order4.OrderDetails.Add(orderDetail2);
order4.OrderDetails.Add(orderDetail3);
try
{
    orderService.UpdateOrder(order4);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
Order order5 = new Order(4, customer1);
order5.OrderDetails.Add(orderDetail1);
orderService.UpdateOrder(order5);
allOrders = orderService.QueryAllOrders();
foreach (Order order in allOrders)
{
    Console.WriteLine(order);
}
Console.WriteLine();

// 测试按订单号查询订单
//Console.WriteLine("Test QueryOrdersByOrderId:");
//List<Order> orders = orderService.GetOrderById(3);
//foreach (Order order in orders)
//{
    //Console.WriteLine(order);
//}
//Console.WriteLine();

// 测试按商品名称查询订单
Console.WriteLine("Test QueryOrdersByGoodsName:");
List<Order> orders = orderService.QueryOrdersByGoodsName("Apple");
foreach (Order order in orders)
{
    Console.WriteLine(order);
}
Console.WriteLine();

// 测试按客户名称查询订单
Console.WriteLine("Test QueryOrdersByCustomerName:");
orders = orderService.QueryOrdersByCustomerName("Bob");
foreach (Order order in orders)
{
    Console.WriteLine(order);
}
Console.WriteLine();

// 测试按订单总金额查询订单
Console.WriteLine("Test QueryOrdersByTotalAmount:");
orders = orderService.QueryOrdersByTotalAmount(130);
foreach (Order order in orders)
{
    Console.WriteLine(order);
}
Console.WriteLine();

// 测试排序
Console.WriteLine("Test Sort:");
orderService.Sort();
allOrders = orderService.QueryAllOrders();
foreach (Order order in allOrders)
{
    Console.WriteLine(order);
}
Console.WriteLine();

Console.ReadLine();
