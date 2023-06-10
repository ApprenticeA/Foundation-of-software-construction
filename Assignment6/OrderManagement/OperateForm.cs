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
    public partial class OperateForm : Form
    {
        public OperateForm()
        {
            InitializeComponent();
        }
        public Add addForm;
        public Update updateForm;
        public Delete deleteForm;
        public Search searchForm;
        public static OrderService orderservice=new OrderService();//为啥这里加上自定义就可以了？
        private void CloseForm()
        {
            foreach (Control item in this.panel3.Controls)
            {
                if (item is Form)
                {
                    Form form = (Form)item;
                    form.Close();
                    this.panel1.Controls.Remove(form);
                }
            }
        }
        private void AddOrder_Click(object sender, EventArgs e)
        {
            CloseForm();
            addForm = new Add();
            addForm.TopLevel = false;
            addForm.FormBorderStyle = FormBorderStyle.None;
            addForm.Dock = DockStyle.Fill;
            addForm.Visible = true;
            this.panel3.Controls.Add(addForm);
        }

        private void UpdateOrder_Click(object sender, EventArgs e)
        {
            CloseForm();
            updateForm = new Update();
            updateForm.TopLevel = false;
            updateForm.FormBorderStyle = FormBorderStyle.None;
            updateForm.Dock = DockStyle.Fill;
            updateForm.Visible = true;
            this.panel3.Controls.Add(updateForm);
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            CloseForm();
            deleteForm = new Delete();
            deleteForm.TopLevel = false;
            deleteForm.FormBorderStyle = FormBorderStyle.None;
            deleteForm.Dock = DockStyle.Fill;
            deleteForm.Visible = true;
            this.panel3.Controls.Add(deleteForm);
        }

        private void SearchOrder_Click(object sender, EventArgs e)
        {
            CloseForm();
            searchForm = new Search();
            searchForm.TopLevel = false;
            searchForm.FormBorderStyle = FormBorderStyle.None;
            searchForm.Dock = DockStyle.Fill;
            searchForm.Visible = true;
            this.panel3.Controls.Add(searchForm);
        }
    }
}
