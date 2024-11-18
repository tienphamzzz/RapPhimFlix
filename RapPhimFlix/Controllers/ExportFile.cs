using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimFlix.Controllers
{
    public class ExportFile
    {
        public static void loadImage(PictureBox ptb, string path, string nameImage)
        {
            try
            {
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                string fullPath = Path.Combine(Application.StartupPath, path + "\\" + nameImage);
                ptb.Image = Image.FromFile(fullPath);
            }
            catch (Exception e)
            {
                //textBox1.Text = "Lỗi lòi mắt " + e.Message;
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                string fullPath = Path.Combine(Application.StartupPath, $"Resources\\images\\phims\\No Infomation.jpg");
                ptb.Image = Image.FromFile(fullPath);
            }
        }
        public static void saveImage(PictureBox ptb, string path, string newFileName)
        {
            try
            {
                if (ptb.ImageLocation == null) return;
                // Lấy đường dẫn thư mục lưu trữ
                string appRoot = Application.StartupPath;
                string fullPath = Path.Combine(appRoot, path);
                Directory.CreateDirectory(fullPath);

                // Tạo đường dẫn file đích với tên mới
                string destinationPath = Path.Combine(fullPath, newFileName);

                // Sao chép ảnh từ vị trí gốc vào thư mục đích với tên mới
                File.Copy(ptb.ImageLocation, destinationPath, true);
            }
            catch
            {

            }
        }
        public static string ReadFileOrDefault(string nameFile)
        {
            try
            {
                string fullPath = Path.Combine(Application.StartupPath, $"Resources\\filedata\\{nameFile}");
                return File.ReadAllText(fullPath);
            }
            catch (Exception e)
            {
                //textBox1.Text = "Lỗi lòi mắt " + e.Message;
            }
            return null;
        }

        public static void CreateInvoice(DataTable tblCTHDVP, DataRow rowHD, DataRow rowK, string tenPhim, decimal giaVe)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string fullPath = Path.Combine(Application.StartupPath, $"Resources\\hoadon\\HoaDonExcel.xlsx");

            using (var package = File.Exists(fullPath)
                ? new ExcelPackage(new FileInfo(fullPath))
                : new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(rowHD["MaHoaDon"].ToString());

                // Thiết lập tiêu đề và thông tin chung
                AddInvoiceHeader(worksheet, rowHD, rowK);

                // Thêm danh sách vé
                AddInvoiceDetails(worksheet, tblCTHDVP, tenPhim, giaVe, (decimal)rowHD["TongTien"]);

                // Ghi file
                SaveExcelFile(package, fullPath);
            }
        }

        private static void AddInvoiceHeader(ExcelWorksheet worksheet, DataRow rowHD, DataRow rowK)
        {
            // Tiêu đề
            worksheet.Cells["A1:G1"].Merge = true;
            worksheet.Cells["A1"].Value = "RẠP CHIẾU PHIM FLIX";
            worksheet.Cells["A1"].Style.Font.Size = 18;
            worksheet.Cells["A1"].Style.Font.Bold = true;
            worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            worksheet.Cells["A2:G2"].Merge = true;
            worksheet.Cells["A2"].Value = "HOÁ ĐƠN THANH TOÁN SẢN PHẨM";
            worksheet.Cells["A2"].Style.Font.Size = 14;
            worksheet.Cells["A2"].Style.Font.Bold = true;
            worksheet.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            // Thông tin hóa đơn
            worksheet.Cells["A3:B3"].Merge = true;
            worksheet.Cells["A4:B4"].Merge = true;
            worksheet.Cells["A5:B5"].Merge = true;
            worksheet.Cells["A6:B6"].Merge = true;
            worksheet.Cells["A3"].Value = "Mã hóa đơn:";
            worksheet.Cells["C3"].Value = rowHD["MaHoaDon"];
            worksheet.Cells["A4"].Value = "Ngày lập hóa đơn:";
            worksheet.Cells["C4"].Value = ((DateTime)rowHD["NgayBan"]).ToString("dd/MM/yyyy");
            worksheet.Cells["A5"].Value = "Tên khách hàng:";
            worksheet.Cells["C5"].Value = rowK["TenKhach"];
            worksheet.Cells["A6"].Value = "SĐT:";
            worksheet.Cells["C6"].Value = rowK["MaKhach"];
        }

        private static void AddInvoiceDetails(ExcelWorksheet worksheet, DataTable tblCTHDVP, string tenPhim, decimal giaVe, decimal TongTien)
        {
            // Tiêu đề bảng
            worksheet.Cells["A8"].Value = "STT";
            worksheet.Cells["B8"].Value = "Mã vé";
            worksheet.Cells["C8"].Value = "Phòng chiếu";
            worksheet.Cells["D8"].Value = "Ghế";
            worksheet.Cells["E8"].Value = "Phim";
            worksheet.Cells["F8"].Value = "Suất chiếu";
            worksheet.Cells["G8"].Value = "Giá vé";

            int i = 1;
            foreach (DataRow row in tblCTHDVP.Rows)
            {
                worksheet.Cells[$"A{8 + i}"].Value = i;
                worksheet.Cells[$"B{8 + i}"].Value = row["MaVe"];
                worksheet.Cells[$"C{8 + i}"].Value = row["MaVe"].ToString().Split("-")[1];
                worksheet.Cells[$"D{8 + i}"].Value = row["MaVe"].ToString().Split("-")[2];
                worksheet.Cells[$"E{8 + i}"].Value = tenPhim;
                worksheet.Cells[$"F{8 + i}"].Value = row["MaVe"].ToString().Split("-")[0];
                worksheet.Cells[$"G{8 + i}"].Value = giaVe;
                i++;
            }

            // Định dạng văn bản
            worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[$"A8:G{8 + i - 1}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            // Tổng tiền
            worksheet.Cells[$"F{8 + i}"].Value = "Tổng tiền:";
            worksheet.Cells[$"G{8 + i}"].Value = TongTien;
            worksheet.Cells[$"G{8 + i}"].Style.Font.Bold = true;
        }

        private static void SaveExcelFile(ExcelPackage package, string fullPath)
        {
            try
            {
                if (File.Exists(fullPath)) package.Save();
                else File.WriteAllBytes(fullPath, package.GetAsByteArray());
            }
            catch (Exception ex)
            {
                throw new IOException("Không thể ghi file. Vui lòng kiểm tra xem file có đang mở không.", ex);
            }
        }
        
        public static void CreateInvoice(DataTable tblCTHDSP_SP, DataRow rowHD, DataRow rowK)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            string fullPath = Path.Combine(Application.StartupPath, $"Resources\\hoadon\\HoaDonExcel.xlsx");
            using (var package = File.Exists(fullPath)
                ? new ExcelPackage(new FileInfo(fullPath))
                : new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(rowHD["MaHoaDon"].ToString());
                AddInvoiceHeader(worksheet, rowHD, rowK);

                AddInvoiceDetails(worksheet, tblCTHDSP_SP, (decimal)rowHD["TongTien"]);

                SaveExcelFile(package, fullPath);
            }
        }
        private static void AddInvoiceDetails(ExcelWorksheet worksheet, DataTable tblCTHDSP_SP, decimal TongTien)
        {
            worksheet.Cells["A8"].Value = "STT";
            worksheet.Cells["B8"].Value = "Tên sản phẩm";
            worksheet.Cells["C8"].Value = "Loại sản phẩm";
            worksheet.Cells["D8"].Value = "Số lượng";
            worksheet.Cells["E8"].Value = "Thành tiền";
            int i = 1;
            foreach (DataRow row in tblCTHDSP_SP.Rows)
            {
                worksheet.Cells[$"A{8 + i}"].Value = i;
                worksheet.Cells[$"B{8 + i}"].Value = row["TenSanPham"];
                worksheet.Cells[$"C{8 + i}"].Value = row["LoaiSanPham"];
                worksheet.Cells[$"D{8 + i}"].Value = row["SLBan"];
                worksheet.Cells[$"E{8 + i}"].Value = row["ThanhTien"];
                i++;
            }
            worksheet.Cells[$"A8:E{8 + i - 1}"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[$"A8:E{8 + i - 1}"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[$"A8:E{8 + i - 1}"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[$"A8:E{8 + i - 1}"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[$"A8:E{8 + i - 1}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            worksheet.Cells[$"D{8 + i}"].Value = "Tổng tiền:";
            worksheet.Cells[$"E{8 + i}"].Value = TongTien;
            worksheet.Cells[$"E{8 + i}"].Style.Font.Bold = true;
        }
    }
}
