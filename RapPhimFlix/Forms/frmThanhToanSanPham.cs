using RapPhimFlix.Appsetting;
using RapPhimFlix.Controllers;
using RapPhimFlix.Forms.MenuNav;
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
    public partial class frmThanhToanSanPham : Form
    {
        private frmChonSanPham _frm;
        private DataRow _khach;
        private DataTable _CTHD_SP;
        private DataRow _hoaDon;
        public event EventHandler AddButtonClicked;
        public frmThanhToanSanPham(List<ListViewItem> items)
        {
            InitializeComponent();

            //_frm = frm;

            foreach (ListViewItem item in items)
            {
                lvProductsInfomations.Items.Add(item);

                txtTotal.Text = (float.Parse(txtTotal.Text) + float.Parse(item.SubItems[3].Text)).ToString();
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            //this.Close();

            //_frm.Show();
            AddButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thanh toán!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                TaoHoaDon();
                if (MessageBox.Show("Bạn có muốn in hoá đơn luôn!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    inHoaDon();

                }
            }  
        }
        private void inHoaDon()
        {
            ExportFile.CreateInvoice(_CTHD_SP, _hoaDon, _khach);
        }
        private void TaoHoaDon()
        {
            TaoKhach();
            DateTime day = DateTime.Now;
            string _maNhanVien = FormNhanVien._maNhanVien;
            string _mhd = AppSetting.GenerateMa();
            decimal _tongTien = decimal.Parse(txtTotal.Text);
            object[] pr1 = { _mhd, day, _tongTien, _maNhanVien, txtSoDienThoai.Text };
            DataProvider.Instance.ExcuteNonQuery("insert into tblHoaDon ( MaHoaDon , NgayBan , TongTien , MaNhanVien , MaKhach ) values ( @MaHoaDon , @NgayBan , @TongTien , @MaNhanVien , @MaKhach )", pr1);
            _hoaDon = DataProvider.Instance.ExcuteQuery("Select * from tblHoaDon where MaHoaDon = @m", new object[] {_mhd}).Rows[0];
            TaoSanPham_ChiTietHoaDon(_mhd);
        }
        private void TaoSanPham_ChiTietHoaDon(string maHoaDon)
        {
            foreach (ListViewItem item in lvProductsInfomations.Items)
            {
                string _maSanPham = DataProvider.Instance.ExcuteQuery("Select MaSanPham from tblSanPham where TenSanPham = @Ten", new object[] { item.SubItems[0].Text }).Rows[0]["MaSanPham"].ToString();
                object[] pr = {maHoaDon, _maSanPham, int.Parse(item.SubItems[2].Text), 0, decimal.Parse(item.SubItems[3].Text) };
                DataProvider.Instance.ExcuteNonQuery("insert into tblChiTietHoaDonSanPham ( MaHoaDon , MaSanPham , SLBan , GiamGia , ThanhTien ) values ( @MaHoaDon , @MaSanPham , @SLBan , @GiamGia , @ThanhTien )", pr);
            }
            _CTHD_SP = DataProvider.Instance.ExcuteQuery("Select * from tblChiTietHoaDonSanPham hdsp inner join tblSanPham sp on hdsp.MaSanPham = sp.MaSanPham where hdsp.MaHoaDon = @m" , new object[] {maHoaDon});
        }
        private void TaoKhach()
        {
            object[] pr1 = { txtSoDienThoai.Text };
            DataTable dt = DataProvider.Instance.ExcuteQuery("select * from tblKhach where MaKhach = @MaKhach", pr1);
            if (dt.Rows.Count <= 0)
            {
                object[] pr2 = { txtSoDienThoai.Text, txtTenKhach.Text };
                DataProvider.Instance.ExcuteNonQuery("insert into tblKhach ( MaKhach , TenKhach ) values ( @MaKhach , @TenKhach )", pr2);
            }
            dt = DataProvider.Instance.ExcuteQuery("select * from tblKhach where MaKhach = @MaKhach", pr1);
            _khach = dt.Rows[0];
        }
        private void txt_TextChanged(object sender, EventArgs e) { btnPay.Enabled = check(); }
        private void rbSex_Click(object sender, EventArgs e) { btnPay.Enabled = check(); }
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string MaHoaDon()
        {
            Random ran = new Random();
            return ran.Next(99, 999).ToString() + ran.Next(99, 999).ToString();
        }
        private bool check()
        {
            if (txtTenKhach.Text == "") return false;
            if (txtSoDienThoai.Text == "" || !Annotation.TelephoneNumber(txtSoDienThoai.Text)) return false;
            if (!rbFemale.Checked && !rbMale.Checked) return false;
            return true;
        }
    }
}
