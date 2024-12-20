﻿using RapPhimFlix.Controllers;
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
    public partial class ChiTietNV : Form
    {
        Controllers.DataProvider dtbase = Controllers.DataProvider.Instance;
        private string maNhanVien;
        public ChiTietNV(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien; // gán giá trị mã nhân viên được truyền vào
            LoadChiTietNhanVien();
            txt_MaNV.Enabled = false;
            txt_ChucVu.Enabled = false;
            txt_TenNV.Enabled = false;
            txt_SDT.Enabled = false;
            txt_Luong.Enabled = false;
            txt_GioiTinh.Enabled = false;
            txt_MatKhau.Enabled = false;
            txt_TaiKhoan.Enabled = false;

        }


        private void LoadChiTietNhanVien()
        {
            try
            {
                string sql = "select nv.GioiTinh,nv.HovaTen,nv.Luong,nv.MaNhanVien,nv.SDT,tk.MatKhau,nv.ChucVu from [dbo].[tblNhanVien] nv join [dbo].[tblTaiKhoan] tk on nv.MaNhanVien=tk.MaNhanVien WHERE nv.MaNhanVien = '" + maNhanVien + "'";
                DataTable dt = dtbase.ExcuteQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    // Giả sử bạn có các TextBox để hiển thị thông tin chi tiết nhân viên
                    txt_MaNV.Text = row["MaNhanVien"].ToString();
                    txt_TenNV.Text = row["HovaTen"].ToString();
                    txt_ChucVu.Text = row["ChucVu"].ToString();
                    txt_SDT.Text = row["SDT"].ToString();
                    txt_Luong.Text = row["Luong"].ToString();
                    txt_GioiTinh.Text = row["GioiTinh"].ToString();
                    txt_MatKhau.Text = row["MatKhau"].ToString();
                    txt_TaiKhoan.Text = row["SDT"].ToString();
                    // Thêm các trường khác tương tự
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_ChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
