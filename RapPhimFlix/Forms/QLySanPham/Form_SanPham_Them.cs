using RapPhimFlix.Controllers;
using RapPhimFlix.Forms.QLyPhim;
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
    public partial class Form_SanPham_Them : Form
    {
        private FormQuanLy formQLy;
       
        bool check = false;
        public Form_SanPham_Them(FormQuanLy formQLy)
        {
            InitializeComponent();
            this.formQLy = formQLy;
            cbb_SanPham_Them.Items.Add("Đồ ăn");
            cbb_SanPham_Them.Items.Add("Đồ uống");
        }

        private void btn_SanPham_Them_XacNhan_Click(object sender, EventArgs e)
        {
            string maSP = tb_SanPham_Them_MaSP.Text;
            string gia = tb_SanPham_Them_Gia.Text;

            string tenSP = tb_SanPham_Them_TenSP.Text;
            string loaiSanPham = cbb_SanPham_Them.Text;

            // Lấy đường dẫn ảnh từ PictureBox
            string anhSanPham = ptb_SanPham_Them.ImageLocation;
            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(gia) ||
            string.IsNullOrWhiteSpace(tenSP) ||
            string.IsNullOrWhiteSpace(loaiSanPham) || string.IsNullOrWhiteSpace(anhSanPham))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!Double.TryParse(gia, out double giaHopLe))
            {
                MessageBox.Show("Giá phải là một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string insertQuery = "INSERT INTO tblSanPham (MaSanPham, Gia, LoaiSanPham, TenSanPham,  Anh) " +
                     "VALUES ('" + maSP + "', '" + giaHopLe + "', N'" + loaiSanPham + "', N'" + tenSP + "','" + anhSanPham + "')";


            int result = DataProvider.Instance.ExcuteNonQuery(insertQuery);

            if (result!=0)
            {
                check = true;
                DialogResult result1 = MessageBox.Show("Bạn đã thêm sản phẩm thành công ! Bạn muốn quay lại danh sách phim không?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {

                    formQLy.OpenFormChild(new Form_DanhSachSanPham(formQLy));
                    formQLy.hien_thanhButton();
                }
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
        }

        private void btn_SanPham_Them_ChonTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn tệp cần mở";               // Tiêu đề hộp thoại
            open.Filter = "Tệp ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Bộ lọc
            open.Multiselect = false;                    // Cho phép chọn nhiều tệp (true/false)
            open.InitialDirectory = "Resources";
            string selectedFilePath = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = open.FileName;

            }

            ptb_SanPham_Them.ImageLocation = selectedFilePath;
        }

        private void tb_SanPham_Them_TenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemPhim_quaylai_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                formQLy.OpenFormChild(new Form_DanhSachSanPham(formQLy));
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
                    formQLy.OpenFormChild(new Form_DanhSachSanPham(formQLy));
                    formQLy.hien_thanhButton();
                }
            }
        }
    }

}
