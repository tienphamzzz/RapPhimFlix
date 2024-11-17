using RapPhimFlix.Controllers;
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
    public partial class Form_SuatChieu_Sua : Form
    {
        private FormQuanLy formQLy;
        DataContext db = new DataContext();
        private string index;
        bool check = false;
        public Form_SuatChieu_Sua(FormQuanLy formQLy, string id)
        {
            InitializeComponent();
            this.formQLy = formQLy;
            this.index = id;
            DataTable dt = db.ReadData("SELECT (select Ten from tblPhims where MaPhim = a.MaPhim) as TenPhim,  NgayChieu,(select ThoiLuong from tblPhims where MaPhim = a.MaPhim) as ThoiLuong,a.CaChieu,a.GiaVe, (select TenPhong from tblPhongChieu where MaPhongChieu = a.MaPhongChieu) as TenPhong FROM tblSuatChieu as a where a.MaSuatChieu ='" + id + "'");
            cbb_TenPhim.Text = dt.Rows[0]["TenPhim"].ToString();
            string ca = dt.Rows[0]["CaChieu"].ToString();
            int dashIndex = ca.IndexOf('-');
            cbb_Ca_begin.Text = ca.Substring(0, dashIndex);
            cbb_Ca_end.Text = ca.Substring(dashIndex + 1);
            tb_SuatChieu_Sua_GiaVe.Text = dt.Rows[0]["GiaVe"].ToString();
            cbb_PhongChieu.Text = dt.Rows[0]["TenPhong"].ToString();
            DateTime namPH = Convert.ToDateTime(dt.Rows[0]["NgayChieu"].ToString());
            dateTimePicker1.Value = namPH;
            DataTable dt1 = db.ReadData("Select TenPhong from tblPhongChieu");
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbb_PhongChieu.Items.Add(dt1.Rows[i]["TenPhong"]);
            }
            DataTable dt2 = db.ReadData("Select Ten from tblPhims");
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbb_TenPhim.Items.Add(dt2.Rows[i]["Ten"]);
            }
            for (int i = 0; i <= 23; i++)
            {
                cbb_Ca_begin.Items.Add(i);
                cbb_Ca_end.Items.Add(i);
            }
        }

        private void btn_SuatChieu_Sua_XacNhan_Click(object sender, EventArgs e)
        {
            string ten = cbb_TenPhim.Text;
            string gia = tb_SuatChieu_Sua_GiaVe.Text;
            string phong = cbb_PhongChieu.Text;
            string begin = cbb_Ca_begin.Text;
            string end = cbb_Ca_end.Text;
            DateTime ngay = dateTimePicker1.Value;
            string ngayChieu = ngay.ToString("yyyy-MM-dd");
            if (string.IsNullOrWhiteSpace(ten) ||
                string.IsNullOrWhiteSpace(gia) ||
                string.IsNullOrWhiteSpace(phong) ||
                string.IsNullOrWhiteSpace(begin) ||
                string.IsNullOrWhiteSpace(end))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Double.TryParse(gia, out double giaHopLe))
            {
                MessageBox.Show("Giá phải là một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string cachieu = begin + "-" + end;
            string query = "UPDATE tblSuatChieu SET MaPhim = (SELECT MaPhim FROM tblPhims WHERE Ten = '" + ten + "'), GiaVe = '" + giaHopLe + "', MaPhongChieu = (SELECT MaPhongChieu FROM tblPhongChieu WHERE TenPhong = N'" + phong + "'), CaChieu = '" + cachieu + "', NgayChieu = '" + ngayChieu + "' WHERE MaSuatChieu = '" + index + "'";
            bool result = db.ChangeData(query);
            if (result)
            {
                check= true;
                DialogResult result1 = MessageBox.Show("Bạn đã sửa suất chiếu thành công! Bạn muốn quay lại danh sách suất chiếu không?",
                                                                       "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    formQLy.OpenFormChild(new Form_DanhSachSuatChieu(formQLy));
                    formQLy.hien_thanhButton();
                }
            }
            else
            {
                MessageBox.Show("Cập nhật suất chiếu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ThemSuatChieu_quaylai_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                formQLy.OpenFormChild(new Form_DanhSachSuatChieu(formQLy));
                formQLy.hien_thanhButton();
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Bạn chưa hoàn tất thêm ! Bạn muốn quay lại danh sách phim không?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {
                    formQLy.OpenFormChild(new Form_DanhSachSuatChieu(formQLy));
                    formQLy.hien_thanhButton();
                }
            }
        }
    }
}
