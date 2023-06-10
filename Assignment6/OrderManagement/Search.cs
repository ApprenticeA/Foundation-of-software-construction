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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void SearchBySum_Click(object sender, EventArgs e)
        {
             int key = int.Parse(SearchKey.Text);
            List<Order> orderlist = OperateForm.orderservice.SelectBySumPrice(key);
            var orderdetailslist = orderlist.Select(o => new {
                商品单价 = o.orderDetail.Price,
                商品数量 = o.orderDetail.Amount,
                商品名称 = o.orderDetail.Name,
                交易日期 = o.Date,
                总金额 = o.Sum,
                用户 = o.Customer,
                订单号 = o.ID, 
            });
            Result.DataSource = orderdetailslist.ToList();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            List<Order> orderlist = OperateForm.orderservice.SelectAll();
            var orderdetailslist = orderlist.Select(o => new {
                商品单价 = o.orderDetail.Price,
                商品数量 = o.orderDetail.Amount,
                商品名称 = o.orderDetail.Name,
                交易日期 = o.Date,
                总金额 = o.Sum,
                用户 = o.Customer,
                订单号 = o.ID,
            });
            Result.DataSource = orderdetailslist.ToList();
        }

        private void SearchByID_Click(object sender, EventArgs e)
        {
            int key = int.Parse(SearchKey.Text);
            List<Order> orderlist = OperateForm.orderservice.SearchByOrderID(key);
            var orderdetailslist = orderlist.Select(o => new {
                商品单价 = o.orderDetail.Price,
                商品数量 = o.orderDetail.Amount,
                商品名称 = o.orderDetail.Name,
                交易日期 = o.Date,
                总金额 = o.Sum,
                用户 = o.Customer,
                订单号 = o.ID,
            });
            Result.DataSource = orderdetailslist.ToList();
        }

        private void SearchByClient_Click(object sender, EventArgs e)
        {
            string key=SearchKey.Text;
            List<Order> orderlist = OperateForm.orderservice.SearchByCustomerName(key);
            var orderdetailslist = orderlist.Select(o => new {
                商品单价 = o.orderDetail.Price,
                商品数量 = o.orderDetail.Amount,
                商品名称 = o.orderDetail.Name,
                交易日期 = o.Date,
                总金额 = o.Sum,
                用户 = o.Customer,
                订单号 = o.ID,
            });
            Result.DataSource = orderdetailslist.ToList();
        }

        private void SearchByDate_Click(object sender, EventArgs e)
        {
            string key = SearchKey.Text;
            List<Order> orderlist = OperateForm.orderservice.SearchByDate(key);
            var orderdetailslist = orderlist.Select(o => new {
                商品单价 = o.orderDetail.Price,
                商品数量 = o.orderDetail.Amount,
                商品名称 = o.orderDetail.Name,
                交易日期 = o.Date,
                总金额 = o.Sum,
                用户 = o.Customer,
                订单号 = o.ID,
            });
            Result.DataSource = orderdetailslist.ToList();
        }
    }
}
