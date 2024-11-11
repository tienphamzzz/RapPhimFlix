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
        public FormQuanLy()
        {
            InitializeComponent();
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
    }
}
