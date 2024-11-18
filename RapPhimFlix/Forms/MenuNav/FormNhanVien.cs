﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapPhimFlix.Forms.DangNhap;

namespace RapPhimFlix.Forms.MenuNav
{
    public partial class FormNhanVien : Form
    {

        public static string _maNhanVien;
        private Form _childFormPhim;
        private Form _childFormSanPham;
        private FormDangNhap formDangNhap;

        public FormNhanVien(string tenNhanVien, string maNhanVien)

        {
            InitializeComponent();
            txt_NhanVien_Ten.Text = tenNhanVien;
            txt_NhanVien_Ten.Enabled = false;
            _maNhanVien = maNhanVien;
            _childFormPhim = new display();
            _childFormSanPham = new displaySP();
            OpenChildForm(_childFormPhim); _childFormPhim.Show();
            OpenChildForm(_childFormSanPham); _childFormSanPham.Hide();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FormNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu form đang đóng và không phải do đóng bằng code (chẳng hạn như bấm nút X)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Đóng toàn bộ ứng dụng
                //Application.Exit();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Nếu người dùng chọn No, ngừng đóng form
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Hủy bỏ sự kiện đóng form
                }
                else
                {
                    // Nếu Yes, cho phép đóng ứng dụng
                    Application.Exit();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Hide();

                // Hiển thị lại form đăng nhập
                formDangNhap = new FormDangNhap();
                formDangNhap.ShowDialog();

                // Đóng form admin hoàn toàn sau khi form đăng nhập đóng
                this.Close();
            }
        }

        private void btn_DanhSachPhim_Click(object sender, EventArgs e)
        {

            _childFormPhim.Show();
            _childFormSanPham.Hide();
        }

        private void OpenChildForm(Form _childForm)
        {
            _childForm.TopLevel = false;
            _childForm.FormBorderStyle = FormBorderStyle.None;
            _childForm.Dock = DockStyle.Fill;
            this.panel_Display.Controls.Add(_childForm);
            _childForm.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _childFormPhim.Hide();
            _childFormSanPham.Show();
        }
    }
}
