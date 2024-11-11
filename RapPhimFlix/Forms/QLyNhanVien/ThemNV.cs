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

namespace RapPhimFlix.Forms.QLyNhanVien
{
    public partial class ThemNV : Form
    {
        public ThemNV()
        {
            InitializeComponent();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string maNV = txt_MaNV.Text;
            string tenNV = txt_TenNV.Text;
            string chucVu = txt_ChucVu.Text;
            string sdt = txt_SDT.Text;
            string luong = txt_Luong.Text;
            string gioiTinh = txt_GioiTinh.Text;
            string matKhau = txt_MatKhau.Text;
            string taiKhoan = txt_TaiKhoan.Text;


            if (string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(tenNV) || string.IsNullOrWhiteSpace(chucVu) ||
        string.IsNullOrWhiteSpace(sdt) || string.IsNullOrWhiteSpace(luong) || string.IsNullOrWhiteSpace(gioiTinh) ||
        string.IsNullOrWhiteSpace(matKhau) || string.IsNullOrWhiteSpace(taiKhoan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlNhanVien = "INSERT INTO tblNhanVien (MaNhanVien, HovaTen, ChucVu, SDT, Luong, GioiTinh) VALUES ('" + maNV + "', '" + tenNV + "', '" + chucVu + "', '" + sdt + "', '" + luong + "', '" + gioiTinh + "');";

            string sqlTaiKhoan = "INSERT INTO tblTaiKhoan (MaNhanVien, MatKhau) VALUES ('" + maNV + "', '" + matKhau + "');";

            DataProvider.Instance.ExcuteNonQuery(sqlNhanVien);
            DataProvider.Instance.ExcuteNonQuery(sqlTaiKhoan);
            MessageBox.Show("thêm thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // 
            this.Close(); // 
        }
    }
}
