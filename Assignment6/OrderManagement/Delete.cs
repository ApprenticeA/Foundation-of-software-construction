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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void ConfirmDelete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(DeleteID.Text);
            OperateForm.orderservice.remove(id);
        }
    }
}
