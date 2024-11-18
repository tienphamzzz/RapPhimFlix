using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms
{
    public partial class displaySP : Form
    {
        private Form _formChild;
        public displaySP()
        {
            InitializeComponent();
            OpenChildForm(new frmChonSanPham());
        }

        private void OpenChildForm(Form child)
        {
            if (_formChild != null) _formChild.Close();
            _formChild = child;
            _formChild.TopLevel = false;
            _formChild.FormBorderStyle = FormBorderStyle.None;
            _formChild.Dock = DockStyle.Fill;
            this.Controls.Add(_formChild);
            _formChild.BringToFront();
            _formChild.Show();
            switch (_formChild)
            {
                case frmChonSanPham:
                    frmChonSanPham form1 = (frmChonSanPham)_formChild;
                    form1.AddButtonThemSanPhamClicked += btn_ChonSanPham_ThanhToan;
                    break;
                case frmThanhToanSanPham: 
                    frmThanhToanSanPham form2 = (frmThanhToanSanPham) _formChild;
                    form2.AddButtonClicked += btn_HuyThanhToan;
                    break;
            }

        }
        private void btn_ChonSanPham_ThanhToan(object? sender, List<ListViewItem> e)
        {
            OpenChildForm(new frmThanhToanSanPham(e));
        }
        private void btn_HuyThanhToan(object? sender, EventArgs e)
        {
            OpenChildForm(new frmChonSanPham());
        }
    }
}
