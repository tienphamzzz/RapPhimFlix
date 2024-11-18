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

namespace RapPhimFlix.Forms.MenuNav.ThongTinPhim
{
    public partial class Form_Phim_Them : Form
    {
        bool check = false;
        
        private FormQuanLy formQLy;
        int cntTheLoai;
        public Form_Phim_Them(FormQuanLy formQuanLy)
        {
            InitializeComponent();
            this.formQLy = formQuanLy;
            DataTable dtb = DataProvider.Instance.ExcuteQuery("select Loai from tblTheLoai");

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                cbb_ThemPhim_TheLoai.Items.Add(dtb.Rows[i]["Loai"].ToString());
            }

        }
        private bool CheckNull()
        {
            foreach (Control ctrl in this.Controls)  //Lặp qua tất cả Controls của form

            {
                if (ctrl is TextBox)  // Kiểm tra TextBox

                {
                    TextBox txtBox = (TextBox)ctrl;
                    if (string.IsNullOrWhiteSpace(txtBox.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btn_ThemPhim_XacNhan_Click(object sender, EventArgs e)
        {
            string Ma_Phim = tb_ThemPhim_MaPhim.Text;
            string Ten = tb_ThemPhim_Tenphim.Text;
            string DaoDien = tb_ThemPhim_DaoDien.Text;
            string QuocGia = tb_ThemPhim_QuocGia.Text;
            string MoTa = tb_ThemPhim_MoTa.Text;
            string TheLoai = cbb_ThemPhim_TheLoai.Text;
            string TenAnh = ptB_Them_Anh.ImageLocation;
            DateTime ngayChieu = dateTimePicker1.Value;
            string NamPhatHanh = ngayChieu.ToString("yyyy-MM-dd");


            //string NamPhatHanh = tb_Phim_Them_NamPhatHanh.Text;            // Check if all required fields are filled
            if (CheckNull() == false || string.IsNullOrEmpty(cbb_ThemPhim_TheLoai.Text) || ptB_Them_Anh.ImageLocation == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TimeSpan.TryParse(tb_ThemPhim_ThoiLuong.Text, out TimeSpan ThoiLuong))
            {
                MessageBox.Show("Invalid TimeSpan format for ThoiLuong. Please use HH:MM:SS format.");
                return;
            }

            //kiem tra xem trong db da ton tai ma phim chua
            var maphim = tb_ThemPhim_MaPhim.Text;
            DataTable dtb = DataProvider.Instance.ExcuteQuery("Select MaPhim from tblPhims where MaPhim ='" + maphim + "'");
            if (dtb.Rows.Count != 0)
            {

                MessageBox.Show("Mã Phim đã tồn tại!");
                return;
            }
            //Nếu Text trong cbb chưa tồn tại thì them moi
            DataTable dtb1 = DataProvider.Instance.ExcuteQuery("select Loai from tblTheLoai");
            DataTable cb = DataProvider.Instance.ExcuteQuery("select * from tblTheLoai where Loai = N'" + TheLoai + "'");
            cntTheLoai = dtb1.Rows.Count;
            if (cb.Rows.Count == 0)
            {
                int rs = DataProvider.Instance.ExcuteNonQuery("insert into tblTheLoai(MaTheLoai,Loai) values('TL" + (cntTheLoai + 1).ToString() + "',N'" + TheLoai + "')");
                if (rs==0)
                {
                    MessageBox.Show("Thêm thể loại lỗi!");
                }
            }

            // Them vao db
            string insert = "INSERT INTO tblPhims (MaPhim, Ten, DaoDien, QuocGia, MoTa, ThoiLuong, TenAnh, NamPhatHanh) " +
                                 "VALUES ('" + Ma_Phim + "', '" + Ten + "','" + DaoDien + "','" + QuocGia + "','" + MoTa + "','" + ThoiLuong + "','" + TenAnh + "','" + NamPhatHanh + "')";

            //kiem tra ket qua them
            int result = DataProvider.Instance.ExcuteNonQuery(insert);
            them_theloai();
            if (result!=0)
            {
                check = true;
                DialogResult result1 = MessageBox.Show("Bạn đã thêm phim thành công ! Bạn muốn quay lại danh sách phim không?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {

                    formQLy.OpenFormChild(new Form_DanhSachPhim(formQLy));
                    formQLy.hien_thanhButton();
                }

            }
            else
            {
                MessageBox.Show("Thêm Phim Lỗi.");
            }


        }

        private void btn_Phim_ThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn tệp cần mở";               // Tiêu đề hộp thoại
            open.Filter = "Tệp ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Bộ lọc
            open.Multiselect = false;                    // Cho phép chọn nhiều tệp (true/false)
            open.InitialDirectory = "C:\\Users\\Administrator\\source\\repos\\RapPhimFlix\\RapPhimFlix\\Resources";
            string selectedFilePath = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = open.FileName;

            }

            ptB_Them_Anh.ImageLocation = selectedFilePath;
        }

        private void cbb_ThemPhim_TheLoai_SelectedIndexChanged(object sender, EventArgs e)

        {

        }

        private void tb_TenQuanLy_TextChanged(object sender, EventArgs e)
        {

        }
        public void them_theloai()
        {
            string loai = "";
            if (cbb_ThemPhim_TheLoai.Text != null)
            {
                loai = cbb_ThemPhim_TheLoai.Text;
            }
            else
            {
                MessageBox.Show("van null");
            }
            // Đọc dữ liệu và kiểm tra kết quả
            string query = "Select MaTheLoai from tblTheLoai where Loai = N'" + loai + "'";
            DataTable dt1 = DataProvider.Instance.ExcuteQuery(query);
            string Ma_Phim = tb_ThemPhim_MaPhim.Text;
            if (dt1.Rows.Count > 0)
            {
                string MaTheloai = dt1.Rows[0]["MaTheLoai"].ToString();


                // Tạo câu truy vấn

                int result = DataProvider.Instance.ExcuteNonQuery("insert into tblTheLoai_Phim (MaPhim,MaTheLoai) values('" + Ma_Phim + "','" + MaTheloai + "')");

                if (result==0)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("them the loai loi");
            }
        }
        private void cbb_ThemPhim_TheLoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemPhim_quaylai_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                formQLy.OpenFormChild(new Form_DanhSachPhim(formQLy));
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
                    formQLy.OpenFormChild(new Form_DanhSachPhim(formQLy));
                    formQLy.hien_thanhButton();
                }
            }

        }

        private void tb_ThemPhim_MaPhim_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
