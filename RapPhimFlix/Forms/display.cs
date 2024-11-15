using Microsoft.VisualBasic.ApplicationServices;
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

namespace RapPhimFlix.Forms
{
    public partial class display : Form
    {
        private Form _formChild;
        
        public display()
        {
            InitializeComponent();
            OpenChildForm(new frmListPhim());
        }
        public void OpenChildForm(Form child)
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
                case frmListPhim:
                    frmListPhim form1 = (frmListPhim)_formChild;
                    form1.AddButtonClicked += btn_ListPhim_SuatChieu_Click;
                    break;
                case frmSuatChieu:
                    frmSuatChieu form2 = (frmSuatChieu)_formChild;
                    form2.AddButtonQuayLayClicked += btn_QuayLaiListPhim_Click;
                    form2.AddButtonClicked += btn_SuatChieu_PhongChieu_Click;
                    break;
                case frmPhongChieu:
                    frmPhongChieu form3 = (frmPhongChieu)_formChild;
                    form3.AddButtonQuayLaiClicked += btn_QuayLaiSuatChieu;
                    form3.AddButtonClicked += btn_PhongChieu_ThanhToan;
                    break;
                case frmThanhToanVePhim:
                    frmThanhToanVePhim form4 = (frmThanhToanVePhim)_formChild;
                    form4.AddButtonHuyClicked += btn_QuayLaiPhongChieu;
                    break;
            }
        }


        private void btn_ListPhim_SuatChieu_Click(object? sender, DataRow phim)
        {
            OpenChildForm(new frmSuatChieu(phim));
        }
        private void btn_SuatChieu_PhongChieu_Click(Object sender, DataRow suatChieu)
        {
            OpenChildForm(new frmPhongChieu(suatChieu));
        }
        private void btn_QuayLaiListPhim_Click(object? sender, EventArgs e)
        {
            OpenChildForm(new frmListPhim());
        }
        private void btn_QuayLaiSuatChieu(object? sender, DataRow phim)
        {
            OpenChildForm(new frmSuatChieu(phim));
        }
        private void btn_PhongChieu_ThanhToan(object? sender, Pair<DataRow, List<string>> e)
        {
            OpenChildForm(new frmThanhToanVePhim(e.First, e.Second));
        }
        private void btn_QuayLaiPhongChieu(object? sender, DataRow _phongChieu)
        {
            OpenChildForm(new frmPhongChieu(_phongChieu));
        }
    }
}
