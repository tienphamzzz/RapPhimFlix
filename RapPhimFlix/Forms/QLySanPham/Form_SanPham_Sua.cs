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
    public partial class Form_SanPham_Sua : Form
    {
        private FormQuanLy formQLy;
       
        private string index;
        bool check = false;
        public Form_SanPham_Sua(FormQuanLy formQLy, string id)
        {
            InitializeComponent();
            this.formQLy = formQLy;
            this.index = id;
            DataTable dt = DataProvider.Instance.ExcuteQuery("select * from tblSanPham where MaSanPham ='" + id + "'");
            tb_SanPham_Sua_Gia.Text = dt.Rows[0]["Gia"].ToString();
            tb_SanPham_Sua_MaSP.Text = dt.Rows[0]["MaSanPham"].ToString();
            tb_SanPham_Sua_TenSP.Text = dt.Rows[0]["TenSanPham"].ToString();
            ptb_SanPham_Sua.ImageLocation = dt.Rows[0]["Anh"].ToString();
            cbb_SanPham_Sua.Text = dt.Rows[0]["LoaiSanPham"].ToString();
            tb_SanPham_Sua_MaSP.Enabled = false;
            cbb_SanPham_Sua.Items.Add("Đồ ăn");
            cbb_SanPham_Sua.Items.Add("Đồ uống");
        }

        private void btn_SanPham_Sua_ChonTep_Click(object sender, EventArgs e)
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
            if (selectedFilePath != "")
            {
                ptb_SanPham_Sua.ImageLocation = selectedFilePath;
            }
        }

        private void btn_SanPham_Sua_XacNhan_Click(object sender, EventArgs e)
        {
            string maSP = tb_SanPham_Sua_MaSP.Text;
            string gia = tb_SanPham_Sua_Gia.Text;

            if (!Double.TryParse(gia, out double giaHopLe))
            {
                MessageBox.Show("Giá phải là một số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string tenSP = tb_SanPham_Sua_TenSP.Text;
            string loaiSanPham = cbb_SanPham_Sua.Text;

            // Lấy đường dẫn ảnh từ PictureBox
            string anhSanPham = ptb_SanPham_Sua.ImageLocation;

            // Kiểm tra dữ liệu
            if (string.IsNullOrWhiteSpace(maSP) || string.IsNullOrWhiteSpace(gia) ||
                string.IsNullOrWhiteSpace(tenSP) || string.IsNullOrWhiteSpace(loaiSanPham) ||
                string.IsNullOrWhiteSpace(anhSanPham) || string.IsNullOrWhiteSpace(loaiSanPham))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem giá có hợp lệ hay không


            // Câu lệnh UPDATE
            string updateQuery = "UPDATE tblSanPham " +
                                 "SET Gia = '" + giaHopLe + "', " +
                                 "    TenSanPham = N'" + tenSP + "', " +
                                 "    LoaiSanPham = N'" + loaiSanPham + "', " +
                                 "    Anh = '" + anhSanPham + "' " +

                                 "WHERE MaSanPham = '" + maSP + "'";

            // Thực thi câu lệnh UPDATE
            int result = DataProvider.Instance.ExcuteNonQuery(updateQuery); // db.ChangeData thực thi câu lệnh SQL

            // Thông báo kết quả
            if (result!=0)
            {
                check = true;
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_SuaSP_quaylai_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                formQLy.OpenFormChild(new Form_DanhSachSanPham(formQLy));
                formQLy.hien_thanhButton();
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Bạn chưa hoàn tất sửa ! Bạn muốn quay lại danh sách sản phẩm không?",
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
