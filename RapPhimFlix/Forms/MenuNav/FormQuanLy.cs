using RapPhimFlix.Forms.DangNhap;
using RapPhimFlix.Forms.MenuNav.SanPham;
using RapPhimFlix.Forms.MenuNav.SuatChieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms.MenuNav
{
    public partial class FormQuanLy : Form
    {
        public FormQuanLy(string tenQuanLy)
        {
            InitializeComponent();
            txt_QuanLy_Ten.Text = tenQuanLy;
            txt_QuanLy_Ten.Enabled = false;
            OpenFormChild(new Form_DanhSachPhim(this));
        }
        private Form currentFormChild;
        public void OpenFormChild(Form childForm)
        {
            //Nếu Form hiện tại đã có thì đóng
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            gb_QuanLy_Body.Controls.Add(childForm);
            gb_QuanLy_Body.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();


        }

        private void btn_QuanLy_SuatChieu_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Form_DanhSachSuatChieu(this));
        }

        private void btn_QuanLy_Phim_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Form_DanhSachPhim(this));
        }

        private void btn_QuanLy_SanPham_Click(object sender, EventArgs e)
        {
            OpenFormChild(new Form_DanhSachSanPham(this));
        }

        private void FormQuanLy_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;
            timer1.Start();
        }

        private void FormQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kiểm tra nếu form đang đóng và không phải do đóng bằng code (chẳng hạn như bấm nút X)
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Đóng toàn bộ ứng dụng
                Application.Exit();
            }
        }

        private void btn_QuanLy_DangXuat_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
