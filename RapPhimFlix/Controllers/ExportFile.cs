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
        public static void loadImage(PictureBox ptb, string nameImage)
        {
            try
            {
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                string fullPath = Path.Combine(Application.StartupPath, $"Resources\\images\\phims\\{nameImage}");
                ptb.Image = Image.FromFile(fullPath);
            }
            catch (Exception e)
            {
                //textBox1.Text = "Lỗi lòi mắt " + e.Message;
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
            if (File.Exists(fullPath))
            {
                using (var package = new ExcelPackage(new FileInfo(fullPath)))
                {

                    var worksheet = package.Workbook.Worksheets.Add(rowHD["MaHoaDon"].ToString());

                    // tiêu đề
                    worksheet.Cells["A1:G1"].Merge = true;
                    worksheet.Cells["A1"].Value = "RẠP CHIẾU PHIM FLIX";
                    worksheet.Cells["A1"].Style.Font.Size = 18;
                    worksheet.Cells["A1"].Style.Font.Bold = true;
                    worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    worksheet.Cells["A2:G2"].Merge = true;
                    worksheet.Cells["A2"].Value = "HOÁ ĐƠN THANH TOÁN";
                    worksheet.Cells["A2"].Style.Font.Size = 14;
                    worksheet.Cells["A2"].Style.Font.Bold = true;
                    worksheet.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    // thông tin chung
                    worksheet.Cells["A3:B3"].Merge = true;
                    worksheet.Cells["A4:B4"].Merge = true;
                    worksheet.Cells["A5:B5"].Merge = true;
                    worksheet.Cells["A6:B6"].Merge = true;
                    worksheet.Cells["A3"].Value = "Mã hóa đơn:";
                    worksheet.Cells["C3"].Value = rowHD["MaHoaDon"];
                    worksheet.Cells["A4"].Value = "Ngày lập hóa đơn:";
                    DateTime ngayBan = (DateTime)rowHD["NgayBan"];
                    worksheet.Cells["C4"].Value = ngayBan.ToString("dd/MM/yyyy");
                    worksheet.Cells["A5"].Value = "Tên khách hàng:";
                    worksheet.Cells["C5"].Value = rowK["TenKhach"];
                    worksheet.Cells["A6"].Value = "SĐT";
                    worksheet.Cells["C6"].Value = rowK["MaKhach"];
                    // danh sách vé
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
                    // định dạng văn bản
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    // tổng tiền
                    worksheet.Cells[$"F{8 + i}"].Value = "Tổng cộng:";
                    worksheet.Cells[$"G{8 + i}"].Value = rowHD["TongTien"];
                    worksheet.Cells[$"G{8 + i}"].Style.Font.Bold = true;


                    try
                    {
                        package.Save();
                    }
                    catch (Exception ex)
                    {
                        throw new IOException("Không thể ghi file. Vui lòng kiểm tra xem file có đang mở không.", ex);
                    }
                }
            }
            else
            {
                using (var package = new ExcelPackage())
                {

                    var worksheet = package.Workbook.Worksheets.Add(rowHD["MaHoaDon"].ToString());

                    // tiêu đề
                    worksheet.Cells["A1:G1"].Merge = true;
                    worksheet.Cells["A1"].Value = "RẠP CHIẾU PHIM FLIX";
                    worksheet.Cells["A1"].Style.Font.Size = 18;
                    worksheet.Cells["A1"].Style.Font.Bold = true;
                    worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    worksheet.Cells["A2:G2"].Merge = true;
                    worksheet.Cells["A2"].Value = "HOÁ ĐƠN THANH TOÁN";
                    worksheet.Cells["A2"].Style.Font.Size = 14;
                    worksheet.Cells["A2"].Style.Font.Bold = true;
                    worksheet.Cells["A2"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    // thông tin chung
                    worksheet.Cells["A3:B3"].Merge = true;
                    worksheet.Cells["A4:B4"].Merge = true;
                    worksheet.Cells["A5:B5"].Merge = true;
                    worksheet.Cells["A6:B6"].Merge = true;
                    worksheet.Cells["A3"].Value = "Mã hóa đơn:";
                    worksheet.Cells["C3"].Value = rowHD["MaHoaDon"];
                    worksheet.Cells["A4"].Value = "Ngày lập hóa đơn:";
                    DateTime ngayBan = (DateTime)rowHD["NgayBan"];
                    worksheet.Cells["C4"].Value = ngayBan.ToString("dd/MM/yyyy");
                    worksheet.Cells["A5"].Value = "Tên khách hàng:";
                    worksheet.Cells["C5"].Value = rowK["TenKhach"];
                    worksheet.Cells["A6"].Value = "SĐT";
                    worksheet.Cells["C6"].Value = rowK["MaKhach"];
                    // danh sách vé
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
                    // định dạng văn bản
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    worksheet.Cells[$"A8:G{8 + i - 1}"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    // tổng tiền
                    worksheet.Cells[$"F{8 + i}"].Value = "Tổng cộng:";
                    worksheet.Cells[$"G{8 + i}"].Value = rowHD["TongTien"];
                    worksheet.Cells[$"G{8 + i}"].Style.Font.Bold = true;


                    try
                    {
                        File.WriteAllBytes(fullPath, package.GetAsByteArray());
                    }
                    catch (Exception ex)
                    {
                        throw new IOException("Không thể ghi file. Vui lòng kiểm tra xem file có đang mở không.", ex);
                    }
                }
            }
        }
    }
}
