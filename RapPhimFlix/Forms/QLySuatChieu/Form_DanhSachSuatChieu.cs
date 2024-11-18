using RapPhimFlix.Controllers;
using RapPhimFlix.Forms.MenuNav.SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms.MenuNav.SuatChieu
{
    public partial class Form_DanhSachSuatChieu : Form
    {
        private FormQuanLy formQLy;
        
        public Form_DanhSachSuatChieu(FormQuanLy formQuanLy)
        {
            InitializeComponent();
            this.formQLy = formQuanLy;
            dgv_SuatChieu.DataSource = DataProvider.Instance.ExcuteQuery("SELECT (select Ten from tblPhims where MaPhim = a.MaPhim) as TenPhim, a.MaSuatChieu, CONVERT(varchar, a.NgayChieu, 103) AS NgayChieu,(select ThoiLuong from tblPhims where MaPhim = a.MaPhim) as ThoiLuong,a.CaChieu,a.GiaVe, a.MaPhongChieu FROM tblSuatChieu as a");
            dgv_SuatChieu.Columns["MaSuatChieu"].Visible = false;
            dgv_SuatChieu.Columns["NgayChieu"].HeaderText = "Ngày Chiếu";
            dgv_SuatChieu.Columns["GiaVe"].HeaderText = "Giá Vé";
            dgv_SuatChieu.Columns["CaChieu"].HeaderText = "Ca Chiếu";
            dgv_SuatChieu.Columns["TenPhim"].HeaderText = "Tên Phim";
            dgv_SuatChieu.Columns["ThoiLuong"].HeaderText = "Thời Lượng";
            dgv_SuatChieu.Columns["MaPhongChieu"].Visible = false;
           
            
        }

        private void dgv_SuatChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) MessageBox.Show("Index out of range");
            formQLy.open_Button();
            formQLy.off_ChiTiet();       
            formQLy.Row_index = dgv_SuatChieu.Rows[e.RowIndex].Cells["MaSuatChieu"].Value?.ToString();
            
        }

        private void btn_SuatChieu_All_Click(object sender, EventArgs e)
        {
            dgv_SuatChieu.DataSource = DataProvider.Instance.ExcuteQuery("SELECT (select Ten from tblPhims where MaPhim = a.MaPhim) as TenPhim, CONVERT(varchar, a.NgayChieu, 103) AS NgayChieu,(select ThoiLuong from tblPhims where MaPhim = a.MaPhim) as ThoiLuong,a.CaChieu,a.GiaVe,a.MaSuatChieu FROM tblSuatChieu as a ");
            dgv_SuatChieu.Columns["MaSuatChieu"].Visible = false;
        }

        private void btn_SuatPhim_Phong1_Click(object sender, EventArgs e)
        {
            DateTime ngayChieu = dateTimePicker1.Value;
            string ngay = ngayChieu.ToString("yyyy-MM-dd");
            dgv_SuatChieu.DataSource = DataProvider.Instance.ExcuteQuery("SELECT (select Ten from tblPhims where MaPhim = a.MaPhim) as TenPhim, CONVERT(varchar, a.NgayChieu, 103) AS NgayChieu,(select ThoiLuong from tblPhims where MaPhim = a.MaPhim) as ThoiLuong,a.CaChieu,a.GiaVe,a.MaSuatChieu FROM tblSuatChieu as a where a.MaPhongChieu ='PC001' and CAST(a.NgayChieu AS DATE)='"+ngay+"'");
            dgv_SuatChieu.Columns["MaSuatChieu"].Visible = false;
        }

        private void btn_SuatPhim_Phong2_Click(object sender, EventArgs e)
        {
            DateTime ngayChieu = dateTimePicker1.Value;
            string ngay = ngayChieu.ToString("yyyy-MM-dd");
            dgv_SuatChieu.DataSource = DataProvider.Instance.ExcuteQuery("SELECT (select Ten from tblPhims where MaPhim = a.MaPhim) as TenPhim, CONVERT(varchar, a.NgayChieu, 103) AS NgayChieu,(select ThoiLuong from tblPhims where MaPhim = a.MaPhim) as ThoiLuong,a.CaChieu,a.GiaVe,a.MaSuatChieu FROM tblSuatChieu as a where a.MaPhongChieu ='PC002' and CAST(a.NgayChieu AS DATE)='" + ngay + "'");
            dgv_SuatChieu.Columns["MaSuatChieu"].Visible = false;
        }

        private void btn_SuatPhim_Phong3_Click(object sender, EventArgs e)
        {
            DateTime ngayChieu = dateTimePicker1.Value;
            string ngay = ngayChieu.ToString("yyyy-MM-dd");
            dgv_SuatChieu.DataSource = DataProvider.Instance.ExcuteQuery("SELECT (select Ten from tblPhims where MaPhim = a.MaPhim) as TenPhim, CONVERT(varchar, a.NgayChieu, 103) AS NgayChieu,(select ThoiLuong from tblPhims where MaPhim = a.MaPhim) as ThoiLuong,a.CaChieu,a.GiaVe,a.MaSuatChieu FROM tblSuatChieu as a where a.MaPhongChieu ='PC003' and CAST(a.NgayChieu AS DATE)='" + ngay + "'");
            dgv_SuatChieu.Columns["MaSuatChieu"].Visible = false;
        }
    }
}
