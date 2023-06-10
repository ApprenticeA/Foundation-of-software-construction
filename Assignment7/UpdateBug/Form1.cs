using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace UpdateBug
{
    public partial class Form1 : Form
    {
        static Crawlers crawler=new Crawlers();
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            label2.Text = " 正在爬取";
            string startUrl=urlBox.Text;
            crawler.urls.Add(startUrl, false);//加入初始页面
            crawler.Crawl();
            var PageList = crawler.list.Select(c => new
            {
                序号 = c.count,
                当前网址 = c.url,
                是否成功 = c.IfOk,
                网页类型=c.type,
            }) ;
            Page.DataSource=PageList.ToList();
            label2.Text = "爬取完成";
        }

        private void Page_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
