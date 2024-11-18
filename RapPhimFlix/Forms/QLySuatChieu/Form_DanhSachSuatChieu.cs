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
            Load();
            addBtn();
        }

        private void Load()
        {
            
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

        private void btn_SuatPhim_Phong_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DateTime ngayChieu = dateTimePicker1.Value;
            string ngay = ngayChieu.ToString("yyyy-MM-dd");
            dgv_SuatChieu.DataSource = DataProvider.Instance.
                ExcuteQuery("SELECT (select Ten from tblPhims where MaPhim = a.MaPhim) " +
                "as TenPhim, CONVERT(varchar, a.NgayChieu, 103) " +
                "AS NgayChieu,(select ThoiLuong from tblPhims where MaPhim = a.MaPhim) " +
                "as ThoiLuong,a.CaChieu,a.GiaVe,a.MaSuatChieu FROM tblSuatChieu " +
                "as a where a.MaPhongChieu = @PC and CAST(a.NgayChieu AS DATE) = @ngay" , new object[] {btn.Tag, ngay});
            dgv_SuatChieu.Columns["MaSuatChieu"].Visible = false;
        }
        private void addBtn()
        {
            Button TatCa = new Button();
            TatCa.Size = new Size(117, 33);
            TatCa.Click += btn_SuatChieu_All_Click;
            TatCa.Text = "Tất cả";
            flp_Phong.Controls.Add(TatCa);
            DataTable dt = DataProvider.Instance.ExcuteQuery("Select * from tblPhongChieu");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(117, 33);
                btn.Click += btn_SuatPhim_Phong_Click;
                btn.Text = dt.Rows[i]["TenPhong"].ToString();
                btn.Tag = dt.Rows[i]["MaPhongChieu"];
                flp_Phong.Controls.Add(btn);
            }
        }
    }
}
