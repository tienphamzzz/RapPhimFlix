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
    public partial class frmThanhToanVePhim : Form
    {
        private List<string> _listGhes;
        private DataRow _suatChieu;
        private DataRow _phim;
        private DataRow _hd;
        private DataRow _khach;
        private DataTable _cthdvp = new DataTable();
        public event EventHandler<DataRow> AddButtonHuyClicked;

        public frmThanhToanVePhim(DataRow suatChieu, List<string> listGhes)
        {
            InitializeComponent();
            _listGhes = listGhes;
            _suatChieu = suatChieu;
            object[] pr = { _suatChieu["MaPhim"].ToString() };
            _phim = DataProvider.Instance.ExcuteQuery("select * from tblPhims where MaPhim = @Maphim", pr).Rows[0];
            Load();
        }
        private string ListGhes()
        {
            string str = "";
            foreach (var item in _listGhes)
                str += $"{item.Split('-')[2]} ";
            return str;
        }
        private void Load()
        {
            string[] tmp = _suatChieu["CaChieu"].ToString().Split('-');
            txt_CaChieu.Text = $"Từ {tmp[0]}h đến {tmp[1]}h";
            txt_GiaVe.Text = $"{_suatChieu["GiaVe"].ToString()}đ";
            DateTime NgayChieu = (DateTime)_suatChieu["NgayChieu"];
            txt_NgayChieu.Text = $"{NgayChieu.ToString("dd/MM/yyyy")}";
            txt_Phim.Text = _phim["Ten"].ToString();
            txt_PhongChieu.Text = _suatChieu["MaPhongChieu"].ToString();
            txt_Ghes.Text = ListGhes();
            txtTotal.Text = $"{_listGhes.Count * decimal.Parse(_suatChieu["GiaVe"].ToString())}";
            ExportFile.loadImage(ptb_Image, _phim["TenAnh"].ToString());
            btnPay.Enabled = false;

        }
        private bool check()
        {
            if (txtCustomerName.Text == "") return false;
            if (txtPhoneNumber.Text == "" || !Annotation.TelephoneNumber(txtPhoneNumber.Text)) return false;
            if (!rbFemale.Checked && !rbMale.Checked) return false;
            return true;
        }
        private void rbSex_Click(object sender, EventArgs e) { btnPay.Enabled = check(); }
        private void txt_TextChanged(object sender, EventArgs e) { btnPay.Enabled = check(); }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận thanh toán!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                TaoHoaDon();
                if (MessageBox.Show("In hoá đơn luôn không!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    XuatHoaDon();
                }
            }
        }
        private void XuatHoaDon()
        {
            ExportFile.CreateInvoice(_cthdvp, _hd, _khach, _phim["Ten"].ToString(), (decimal)_suatChieu["GiaVe"]);
        }
        private void TaoKhach()
        {
            object[] pr1 = { txtPhoneNumber.Text };
            DataTable dt = DataProvider.Instance.ExcuteQuery("select * from tblKhach where MaKhach = @MaKhach", pr1);
            if (dt.Rows.Count <= 0)
            {
                object[] pr2 = { txtPhoneNumber.Text, txtCustomerName.Text };
                DataProvider.Instance.ExcuteNonQuery("insert into tblKhach ( MaKhach , TenKhach ) values ( @MaKhach , @TenKhach )", pr2);
            }
            dt = DataProvider.Instance.ExcuteQuery("select * from tblKhach where MaKhach = @MaKhach", pr1);
            _khach = dt.Rows[0]; 
        }
        private void TaoHoaDon()
        {
            TaoKhach();
            DateTime day = DateTime.Now;
            string MaNhanVien = FormNhanVien._maNhanVien;
            string mhd = MaHoaDon();
            decimal tongTien = 0;
            object[] pr1 = { mhd, day, tongTien, MaNhanVien, txtPhoneNumber.Text };
            DataProvider.Instance.ExcuteNonQuery("insert into tblHoaDon ( MaHoaDon , NgayBan , TongTien , MaNhanVien , MaKhach ) values ( @MaHoaDon , @NgayBan , @TongTien , @MaNhanVien , @MaKhach )", pr1);
            tongTien = TaoVe_ChiTietHoaDon(mhd);
            object[] pr2 = { tongTien, mhd };
            DataTable tam = new DataTable();
            tam.Columns.Add("MaHoaDon", typeof(string));
            tam.Columns.Add("NgayBan", typeof(DateTime));
            tam.Columns.Add("TongTien", typeof(decimal));
            tam.Columns.Add("MaNhanVien", typeof(string));
            tam.Columns.Add("MaKhach", typeof(string));
            _hd = tam.NewRow();
            _hd["MaHoaDon"] = mhd;
            _hd["NgayBan"] = day;
            _hd["TongTien"] = tongTien;
            _hd["MaNhanVien"] = MaNhanVien;
            _hd["MaKhach"] = txtPhoneNumber.Text;
        }
        private decimal TaoVe_ChiTietHoaDon(string mhd)
        {
            _cthdvp.Columns.Add("MaVe", typeof(string));
            _cthdvp.Columns.Add("MaHoaDon", typeof(string));
            _cthdvp.Columns.Add("ThanhTien", typeof(decimal));
            decimal tongtien = 0;
            DateTime day = DateTime.Now;
            Pair<int, decimal> _giamGia = GiamGia();
            decimal thanhTien = ThanhTien(_giamGia.First, _giamGia.Second, (decimal)_suatChieu["GiaVe"]);
            foreach (var ve in _listGhes)
            {
                object[] pr = { ve, day, _suatChieu["MaSuatChieu"] };
                DataProvider.Instance.ExcuteNonQuery("insert into tblVes ( MaVe , NgayBan , MaSuatChieu ) values ( @Mave , @NgayBan , @MaSuatChieu )", pr);
                TatGhe(ve);
                tongtien += thanhTien;
                object[] prGG = { ve,  mhd, thanhTien};
                DataProvider.Instance.ExcuteNonQuery("insert into tblChiTietHoaDonVePhim ( MaVe , MaHoaDon , ThanhTien ) values ( @MaVe , @MaHoaDon , @ThanhTien )", prGG);
                DataRow row = _cthdvp.NewRow();
                row["MaVe"] = ve;
                row["MaHoaDon"] = mhd;
                row["ThanhTien"] = thanhTien;
                _cthdvp.Rows.Add(row);
            }
            return tongtien;
        }
        private void TatGhe(string maGhe)
        {
            object[] pr = {1, maGhe};
            DataProvider.Instance.ExcuteNonQuery("update tblGhes set TrangThai = @TT where MaGhe = @MaGhe", pr);
        }
        private decimal ThanhTien(int phanTram, decimal tienGiam, decimal giaVe)
        {
            decimal tinh = giaVe;
            if (phanTram > 0 && tienGiam > 0)
                tinh = (phanTram * giaVe < tienGiam) ? giaVe - giaVe * phanTram : giaVe - tienGiam;
            else if (phanTram > 0) tinh = giaVe - giaVe * phanTram;
            else if (tienGiam > 0) tinh = giaVe - tienGiam;
            return tinh;
        }
        private Pair<int, decimal> GiamGia()
        {
            if (txt_Discount.Text == "") return new Pair<int, decimal>(0, 0);
            object[] pr = { txt_Discount.Text };
            DataTable dt = DataProvider.Instance.ExcuteQuery("select * from tblGiamGia where MaGiamGia = @MaGiamGia", pr);
            if (dt.Rows.Count <= 0) return new Pair<int, decimal>(0, 0);
            DateTime han = (DateTime)dt.Rows[0]["NgayKetThuc"];
            if (han <= DateTime.Now) return new Pair<int, decimal>(0, 0);
            return new Pair<int, decimal>((int)dt.Rows[0]["PhanTramGiamGia"], (decimal)dt.Rows[0]["SoTienGiamGia"]);
        }
        private string MaHoaDon()
        {
            Random ran = new Random();
            return ran.Next(99, 999).ToString() + ran.Next(99, 999).ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e) { AddButtonHuyClicked?.Invoke(this, _suatChieu); }
    }
}
