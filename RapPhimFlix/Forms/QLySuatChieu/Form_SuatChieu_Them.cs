using RapPhimFlix.Controllers;
using RapPhimFlix.Forms.QLyPhim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms.MenuNav.SuatChieu
{
    public partial class Form_SuatChieu_Them : Form
    {
        private FormQuanLy formQLy;
        
        bool check = false;
        public Form_SuatChieu_Them(FormQuanLy formQLy)
        {
            InitializeComponent();
            this.formQLy = formQLy;
            DataTable dt = DataProvider.Instance.ExcuteQuery("select Ten from tblPhims");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbb_SuatChieu_dsPhim.Items.Add(dt.Rows[i]["Ten"].ToString());
            }
            DataTable dt1 = DataProvider.Instance.ExcuteQuery("Select TenPhong from tblPhongChieu");
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                cbb_SuatChieu_dsPhongChieu.Items.Add(dt1.Rows[i]["TenPhong"]);
            }
            for (int i = 0; i <= 23; i++)
            {
                cbb_Ca_begin.Items.Add(i);
                cbb_Ca_end.Items.Add(i);
            }
        }

        private void btn_SuatChieu_XacNhan_Click(object sender, EventArgs e)
        {
            string maSuatChieu = tb_SuatChieu_Them_MaSC.Text;
            DateTime ngay = dateTimePicker1.Value;
            string ngayChieu = ngay.ToString("yyyy-MM-dd");
            string giaVe = tb_SuatChieu_GiaVe.Text;

            string TenPhim = cbb_SuatChieu_dsPhim.Text;
            string PhongChieu = cbb_SuatChieu_dsPhongChieu.Text;
            DataTable dt = DataProvider.Instance.ExcuteQuery("select MaPhongChieu from tblPhongChieu where TenPhong=N'" + PhongChieu + "'");
            string maPhongChieu = dt.Rows[0]["MaPhongChieu"].ToString();
            // Kiểm tra các giá trị có rỗng không
            if (string.IsNullOrWhiteSpace(cbb_Ca_begin.Text) ||
                string.IsNullOrWhiteSpace(giaVe) || string.IsNullOrWhiteSpace(cbb_Ca_end.Text) ||
                string.IsNullOrWhiteSpace(TenPhim) || string.IsNullOrWhiteSpace(PhongChieu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem giá vé có hợp lệ (số không âm)
            decimal giaVeDecimal;
            if (!decimal.TryParse(giaVe, out giaVeDecimal) || giaVeDecimal <= 0)
            {
                MessageBox.Show("Giá vé không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt1 = DataProvider.Instance.ExcuteQuery("select MaPhim from tblPhims where Ten=N'" + TenPhim + "'");
            string maPhim = dt1.Rows[0]["MaPhim"].ToString();
            string caChieu = cbb_Ca_begin.Text + "-" + cbb_Ca_end.Text;
            DataTable dt2 = DataProvider.Instance.ExcuteQuery("select * from tblSuatChieu as a where a.CaChieu='" + caChieu + "' and CAST(a.NgayChieu AS DATE)='" + ngayChieu + "' and a.MaPhim=(select MaPhim from tblPhims where Ten=N'" + TenPhim + "') and a.MaPhongChieu='" + maPhongChieu + "'");

            if (dt2.Rows.Count > 0)
            {
                MessageBox.Show("Phim có ca chiếu này đã tồn tại");
                return;
            }
            string insertQuery = "INSERT INTO tblSuatChieu (MaSuatChieu, NgayChieu, GiaVe, CaChieu, MaPhim, MaPhongChieu) " +
                                 "VALUES ('" + maSuatChieu + "', '" + ngayChieu + "', '" + giaVe + "', N'" + caChieu + "', '" + maPhim + "', '" + maPhongChieu + "')";

            int result = DataProvider.Instance.ExcuteNonQuery(insertQuery);

            if (result!=0)
            {
                check = true;
                DialogResult result1 = MessageBox.Show("Bạn đã thêm suất chiếu thành công! Bạn muốn quay lại danh sách suất chiếu không?",
                                                       "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result1 == DialogResult.Yes)
                {
                    formQLy.OpenFormChild(new Form_DanhSachSuatChieu(formQLy));
                    formQLy.hien_thanhButton();
                }
            }
            else
            {
                MessageBox.Show("Thêm suất chiếu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
