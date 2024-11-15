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
    public partial class FormNhanVien : Form
    {
        public static string _maNhanVien = "NV001";
        private Form _childForm;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btn_DanhSachPhim_Click(object sender, EventArgs e)
        {
            if (_childForm != null) _childForm.Close();
            _childForm = new display();
            OpenChildForm();
        }

        private void OpenChildForm()
        {
            _childForm.TopLevel = false;
            _childForm.FormBorderStyle = FormBorderStyle.None;
            _childForm.Dock = DockStyle.Fill;
            this.Controls.Add(_childForm);
            _childForm.BringToFront();
            _childForm.Show();
        }
    }
}
