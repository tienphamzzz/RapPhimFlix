using RapPhimFlix.Forms.MenuNav.SanPham;
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

namespace RapPhimFlix.Forms.MenuNav
{
    public partial class Form_DanhSachPhim : Form
    {
        private FormQuanLy formQLy;
        public Form_DanhSachPhim(FormQuanLy formQuanLy)
        {
            InitializeComponent();
            this.formQLy = formQuanLy;
        }

        private void btn_Phim_ChiTiet_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_Phim_ChiTiet());
        }

        private void btn_Phim_Them_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_Phim_Them());
        }

        private void btn_Phim_Sua_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_Phim_Sua());
        }
    }
}
