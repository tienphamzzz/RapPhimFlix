using RapPhimFlix.Forms.MenuNav.ThongTinPhim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms.MenuNav.SanPham
{
    public partial class Form_DanhSachSanPham : Form
    {
        private FormQuanLy formQLy;
        public Form_DanhSachSanPham(FormQuanLy formQuanLy)
        {
            InitializeComponent();
            this.formQLy = formQuanLy;
        }
        private void btn_SanPham_ChiTiet_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_SanPham_ChiTiet());
        }

        private void btn_SanPham_Them_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_SanPham_Them());
        }

        private void btn_SanPham_Sua_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_SanPham_Sua());
        }

        
    }
}
