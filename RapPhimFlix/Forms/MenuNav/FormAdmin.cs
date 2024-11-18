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
using RapPhimFlix.Forms.DangNhap;
using RapPhimFlix.Forms.QLyNhanVien;

namespace RapPhimFlix.Forms.MenuNav
{
    public partial class FormAdmin : Form
    {
        private Form _childForm;
        public FormAdmin(string tenAdmin)
        {
            InitializeComponent();
            txt_Admin_Ten.Text = tenAdmin;
            txt_Admin_Ten.Enabled = false;
            _childForm = new Ql_TaiKhoan();
            OpenChildForm(_childForm);
            _childForm.Show();
        }

        private void txt_Admin_Ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

            // this.ControlBox = false;
            timer1.Start();
        }

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu form đang đóng và không phải do đóng bằng code (chẳng hạn như bấm nút X)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Đóng toàn bộ ứng dụng
                Application.Exit();
            }
        }

        private void btn_Admin_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Đóng form hiện tại
                this.Hide();

                // Hiển thị lại form đăng nhập
                FormDangNhap formDangNhap = new FormDangNhap();
                formDangNhap.ShowDialog();

                // Đóng form admin hoàn toàn sau khi form đăng nhập đóng
                this.Close();
            }
        }

        private void btn_Admin_NhanVien_Click(object sender, EventArgs e)
        {

        }
        private void OpenChildForm(Form _childForm)
        {
            _childForm.TopLevel = false;
            _childForm.FormBorderStyle = FormBorderStyle.None;
            _childForm.Dock = DockStyle.Fill;
            this.panel_Body.Controls.Add(_childForm);
            _childForm.BringToFront();
        }
    }
}
