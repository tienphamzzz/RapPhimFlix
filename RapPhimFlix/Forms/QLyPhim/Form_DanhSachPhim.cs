using RapPhimFlix.Forms.MenuNav.SanPham;
using RapPhimFlix.Forms.MenuNav.ThongTinPhim;
using RapPhimFlix.Forms.MenuNav;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapPhimFlix.Controllers;

namespace RapPhimFlix.Forms.QLyPhim
{
    public partial class Form_DanhSachPhim : Form
    {
        private FormQuanLy formQLy;
        public string Row_index;
        
        public Form_DanhSachPhim(FormQuanLy formQuanLy)
        {
            InitializeComponent();
            
            this.formQLy = formQuanLy;
            dgv_Phim.DataSource = DataProvider.Instance.ExcuteQuery("SELECT p.MaPhim, p.Ten, p.DaoDien, p.QuocGia, p.MoTa, p.ThoiLuong, p.NamPhatHanh, t.Loai AS TheLoai FROM tblPhims p INNER JOIN tblTheLoai_Phim tp ON p.MaPhim = tp.MaPhim INNER JOIN tblTheLoai t ON tp.MaTheLoai = t.MaTheLoai");
            dgv_Phim.Columns["MaPhim"].Visible = false;
            dgv_Phim.Columns["TheLoai"].HeaderText = "Thể loại";
            dgv_Phim.Columns["Ten"].HeaderText = "Tên phim";
            dgv_Phim.Columns["DaoDien"].HeaderText = "Đạo diễn";
            dgv_Phim.Columns["ThoiLuong"].HeaderText = "Thời lượng";
            dgv_Phim.Columns["QuocGia"].HeaderText = "Quốc gia";
            dgv_Phim.Columns["NamPhatHanh"].HeaderText = "Năm phát hành";
            dgv_Phim.Columns["MoTa"].Visible = false;
            //dgv_SanPham.Columns["TenAnh"].Visible = false;
        }

        

        private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            formQLy.Row_index = dgv_Phim.Rows[e.RowIndex].Cells["MaPhim"].Value?.ToString();

            formQLy.open_Button();
        }
    }
}
