using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RapPhimFlix.Appsetting;
using RapPhimFlix.Controllers;
using RapPhimFlix.Forms.MenuNav;

namespace RapPhimFlix.Forms.DangNhap
{
    public partial class FormDangNhap : Form
    {

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txt_DangNhap_MatKhau.PasswordChar = '*';

            //timerHienMK.Stop();
            timerHienMK.Interval = 1000;

            lbHienMK.Text = "Hiện mật khẩu";
        }

        private void btn_DangNhap_DangNhap_Click(object sender, EventArgs e)
        {
            string maNhanVien = txt_DangNhap_TaiKhoan.Text;
            string matKhau = txt_DangNhap_MatKhau.Text;
            if (maNhanVien == AppSetting.Admin && matKhau == AppSetting.Password)
            {
                AppSetting.VaiTro = 0;
                //MessageBox.Show("Hi Admin");

                FormAdmin formAdmin = new FormAdmin("Admin");
                this.Hide();
                formAdmin.ShowDialog();
            }

            string query = "SELECT nv.HovaTen, nv.ChucVu FROM tblTaiKhoan tk " +
                   "INNER JOIN tblNhanVien nv ON tk.MaNhanVien = nv.MaNhanVien " +
                   "WHERE tk.MaNhanVien = @maNhanVien AND tk.MatKhau = @matKhau";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query, new object[] { maNhanVien, matKhau });

            if (dt.Rows.Count > 0)
            {
                //lay ten nguoi dung va chuc vu
                string HovaTen = dt.Rows[0]["HovaTen"].ToString();
                string ChucVu = dt.Rows[0]["ChucVu"].ToString();

                if (ChucVu == "Quản lý")
                {
                    AppSetting.VaiTro = 1;
                    //MessageBox.Show("Hi Quản lý");

                    FormQuanLy formQuanLy = new FormQuanLy(HovaTen);
                    this.Hide();
                    formQuanLy.ShowDialog();
                    //this.Show();
                }
                else if (ChucVu == "Nhân viên")
                {
                    AppSetting.VaiTro = 2;
                    //MessageBox.Show("Hi Nhân viên");

                    FormNhanVien formNhanVien = new FormNhanVien(HovaTen, maNhanVien);
                    this.Hide();
                    formNhanVien.ShowDialog();
                    // this.Show();
                }
            }
            else
                MessageBox.Show("Tên đăng nhập và mật khẩu không đúng.");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);

            // Nếu người dùng chọn Yes, thoát ứng dụng
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void FormDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Hiển thị hộp thoại xác nhận khi người dùng đóng form
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);

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

        private void txt_DangNhap_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DangNhap_MatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btn_DangNhap_DangNhap.PerformClick();
        }

        private void txt_DangNhap_TaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txt_DangNhap_MatKhau.Focus();
        }

        private void timerHienMK_Tick(object sender, EventArgs e)
        {
            txt_DangNhap_MatKhau.PasswordChar = '*';
            timerHienMK.Stop();

            lbHienMK.Text = "Hiện mật khẩu";
        }

        private void lbHienMK_Click(object sender, EventArgs e)
        {
            txt_DangNhap_MatKhau.PasswordChar = '\0'; //Hiển thị mk
            timerHienMK.Start();

            lbHienMK.Text = "Ẩn mật khẩu";
        }
    }
}
