using RapPhimFlix.Controllers;
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
        DataContext db = new DataContext();
        public Form_DanhSachSanPham(FormQuanLy formQuanLy)
        {
            InitializeComponent();
            this.formQLy = formQuanLy;
            dgv_SanPham.DataSource = db.ReadData("select a.MaSanPham,a.TenSanPham,a.LoaiSanPham,a.Gia from tblSanPham as a");
            dgv_SanPham.Columns["TenSanPham"].HeaderText = "Tên Sản phẩm";
            dgv_SanPham.Columns["LoaiSanPham"].HeaderText = "Loại";
            dgv_SanPham.Columns["Gia"].HeaderText = "Giá";
            dgv_SanPham.Columns["MaSanPham"].Visible = false;
        }

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formQLy.open_Button();
            formQLy.Row_index = dgv_SanPham.Rows[e.RowIndex].Cells["MaSanPham"].Value?.ToString();
        }
    }
}
