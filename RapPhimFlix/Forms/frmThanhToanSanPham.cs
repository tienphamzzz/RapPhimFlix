using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms
{
    public partial class frmThanhToanSanPham : Form
    {
        private frmChonSanPham _frm;
        public frmThanhToanSanPham(List<ListViewItem> items, frmChonSanPham frm)
        {
            InitializeComponent();

            _frm = frm;

            foreach (ListViewItem item in items)
            {
                lvProductsInfomations.Items.Add(item);

                txtTotal.Text = (float.Parse(txtTotal.Text) + float.Parse(item.SubItems[3].Text)).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            _frm.Show();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }
    }
}
