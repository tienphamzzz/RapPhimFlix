<<<<<<< HEAD
﻿
=======

>>>>>>> bafcbe9017ea13c7fb7c86b867d87109f0ff119c
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms.QLyNhanVien
{
    public partial class ThemNV : Form
    {
        Controllers.DataProvider dtbase = Controllers.DataProvider.Instance;
        public ThemNV()
        {
            InitializeComponent();
            txt_MaNV.Enabled = false;
        }


        public void ThemMa_NV(Controllers.DataProvider dtbase)
        {
            string query = "SELECT TOP 1 MaNhanVien FROM tblNhanVien ORDER BY MaNhanVien DESC";
            DataTable dt = dtbase.ExcuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                string lastMaNV = dt.Rows[0]["MaNhanVien"].ToString();
                int number = int.Parse(lastMaNV.Substring(2)) + 1;
                txt_MaNV.Text = "NV" + number.ToString("D3");
            }
            else
            {
                txt_MaNV.Text = "NV001";
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string maNV = txt_MaNV.Text;
            string tenNV = txt_TenNV.Text;
            string chucVu = rdo_ChucVuNhanVien.Checked ? "1" : "0";
            string sdt = txt_SDT.Text;
            string luong = txt_Luong.Text;
            string gioiTinh = rdo_GioiTinh_Nam.Checked ? "Nam" : "Nữ";
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

            dtbase.ExcuteNonQuery(sqlNhanVien);
            dtbase.ExcuteNonQuery(sqlTaiKhoan);
            MessageBox.Show("Thêm thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_TaiAnh_Click(object sender, EventArgs e)
        {
           OpenFileDialog TaiAnh = new OpenFileDialog();
            TaiAnh.Filter = "Image files (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            TaiAnh.FilterIndex = 1;
            TaiAnh.Title = "chọn file ảnh";
            if (TaiAnh.ShowDialog() == DialogResult.OK)
            {
               pictureBox_anh.Image=Image.FromFile(TaiAnh.FileName);

            }
            else
            {
                MessageBox.Show("Chưa chọn ảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

