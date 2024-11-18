using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapPhimFlix.Model;
using DevExpress.XtraCharts;
using RapPhimFlix.Controllers;


namespace RapPhimFlix.Forms.QLyNhanVien
{
    public partial class ThongKeDoanhThu : Form
    {
        //    Controllers.DataContext dtbase = new Controllers.DataContext();
    //    Controllers.DataProvider dtbase = Controllers.DataProvider.Instance;
        DataProvider dp = DataProvider.Instance;
        public ThongKeDoanhThu()
        {
            InitializeComponent();
            // this.Load += ThongKeDoanhThu_Load;
        }
        //public List<SanPhamDoanhThu> ThongKeSanPham()
        //{
        //    SanPhamDoanhThu sp;
        //    List<SanPhamDoanhThu> listTk_SP = new List<SanPhamDoanhThu>();
        //    DateTime ngay_dau = new DateTime(DateTime.Now.Year, 1, 1);
        //    var lstNhom = dp.CallThongKeDoanhThuSanPham(ngay_dau, DateTime.Now.AddDays(1)).ToList();
        //    foreach (var item in lstNhom)
        //    {
        //        sp = new SanPhamDoanhThu();
        //        sp.MaSanPham = item.MaSanPham;
        //        sp.TenSanPham = item.TenSanPham;
        //        sp.TongTienBan = item.TongTienBan;
        //        listTk_SP.Add(sp);
        //    }
        //    var t = listTk_SP.Count;
        //    return listTk_SP;
        //}
        public List<SanPhamDoanhThu> ThongKeSanPham(DateTime ngayDau, DateTime ngayCuoi)// lấy dữ liệu từ databse trong khoảng tg r chuyển thành các đối tượng sp để sử dụng ở fille này
        {
            SanPhamDoanhThu sp;
            List<SanPhamDoanhThu> listTk_SP = new List<SanPhamDoanhThu>();
            var lstNhom = dp.CallThongKeDoanhThuSanPham(ngayDau, ngayCuoi).ToList();// trả về 1 list các đối tượng của SanPhamDoanhThu đã có dữ liệu
            foreach (var item in lstNhom)
            {
                sp = new SanPhamDoanhThu();
                sp.MaSanPham = item.MaSanPham;
                sp.TenSanPham = item.TenSanPham;
                sp.TongTienBan = item.TongTienBan;
                listTk_SP.Add(sp);
            }
            var t = listTk_SP.Count;
            return listTk_SP;
        }


        private void ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            //Series series1 = new Series("Doanh thu sản phẩm ", ViewType.Pie);
            //var list = ThongKeSanPham();
            //if (list.Count == 0)
            //{
            //    MessageBox.Show("Không có dữ liệu cho biểu đồ.");
            //    return;
            //}
            //foreach (var item in list)
            //{
            //    series1.Points.Add(new SeriesPoint(item.TenSanPham, item.TongTienBan));
            //}
            //chart_ThongKeSP.Series.Add(series1);
            //series1.Label.TextPattern = "{A}: {VP:p0}";
        }

       



        private void btn_ThongKeSP_Click(object sender, EventArgs e)// lấy dữ liệu đưa lên biểu đồ
        {
            DateTime ngayDau = dtpNgayBatDau.Value;
            DateTime ngayCuoi = dtp_NgayKetThuc.Value;

            // Kiểm tra ngày kết thúc phải sau ngày bắt đầu
            if (ngayCuoi < ngayDau)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu.");
                return;
            }

            // Lấy dữ liệu và cập nhật biểu đồ
            Series series1 = new Series("Doanh thu sản phẩm", ViewType.Doughnut);
            var list = ThongKeSanPham(ngayDau, ngayCuoi);// gán đối tượng trong khoảng thời gian này vào list

            if (list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho biểu đồ.");
                return;
            }

            foreach (var item in list)
            {
                series1.Points.Add(new SeriesPoint(item.TenSanPham, item.TongTienBan)); // thêm 2 dữ liệu vào biểu đồ
            }

            chart_ThongKeSP.Series.Clear(); // Xóa các series cũ trước khi thêm mới
            chart_ThongKeSP.Series.Add(series1);// cập nhật dữ liệu biểu đồ
            series1.Label.TextPattern = "{A}: {VP:p0}"; // mẫu văn bản hiern thị trên biểu đồ
        }




        public List<VePhimDoanhThu> ThongKeVe(DateTime ngayDau, DateTime ngayCuoi)
        {
            VePhimDoanhThu vp;
            List<VePhimDoanhThu> listTk_Ve = new List<VePhimDoanhThu>();
            var lstNhom = dp.CallThongKeDoanhThuVePhim(ngayDau, ngayCuoi).ToList();
            foreach (var item in lstNhom)
            {
                vp = new VePhimDoanhThu
                {
                    ThoiGian = item.ThoiGian,
                    SoLuong = item.SoLuong,
                    TongTienBan = item.TongTienBan
                };
                listTk_Ve.Add(vp);
            }
            return listTk_Ve;
        }

        private void btn_ThongKeVe_Click(object sender, EventArgs e)
        {
            DateTime ngayDau = dtpNgayBatDau.Value;
            DateTime ngayCuoi = dtp_NgayKetThuc.Value;

            // Kiểm tra ngày kết thúc phải sau ngày bắt đầu
            if (ngayCuoi < ngayDau)
            {
                MessageBox.Show("Ngày kết thúc phải sau ngày bắt đầu.");
                return;
            }

            // Lấy dữ liệu và cập nhật biểu đồ
            Series series1 = new Series("Doanh thu vé phim", ViewType.Bar);
            var list = ThongKeVe(ngayDau, ngayCuoi);

            if (list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu cho biểu đồ.");
                return;
            }

            foreach (var item in list)
            {
                series1.Points.Add(new SeriesPoint(item.ThoiGian, item.SoLuong, item.TongTienBan));
            }

            chart_ThongKeVe.Series.Clear(); // Xóa các series cũ trước khi thêm mới
            chart_ThongKeVe.Series.Add(series1);
            //series1.Label.TextPattern = "{A}: {VP:p0}";
            series1.Label.TextPattern = "{A}: SoLuong={V0}, TongTienBan={V1}";


        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các series trong biểu đồ chart_ThongKeSP
            chart_ThongKeSP.Series.Clear();

            // Xóa tất cả các series trong biểu đồ chart_ThongKeVe
            chart_ThongKeVe.Series.Clear();
        }
    }
}
