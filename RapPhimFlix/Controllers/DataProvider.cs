using RapPhimFlix.Model;
using RapPhimFlix.Appsetting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimFlix.Controllers
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = AppSetting.ConnectionString;

        public DataTable ExcuteQuery(string query, object[] parameter = null) // thực hiện một truy vấn SQL và trả về kết quả dưới dạng DataTable
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    int i = 0;

                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }

        public int ExcuteNonQuery(string query, object[] parameter = null) // •	Phương thức này thực hiện một lệnh SQL không trả về dữ liệu (ví dụ: INSERT, UPDATE, DELETE) và trả về số dòng bị ảnh hưởng.
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }

        public object ExcuteScalar(string query, object[] parameter = null)//•	Phương thức này thực hiện một lệnh SQL và trả về một giá trị đơn lẻ (ví dụ: đếm số lượng bản ghi).
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (parameter != null)
                {
                    string[] listPara = query.Split(new char[] { ' ', ',', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                    int i = 0;
                    foreach (string item in listPara)
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                }
                data = command.ExecuteScalar();
                connection.Close();
            }
            return data;
        }


        // phương thúc này dùng để gọi một hàm trong SQL Server ( hàm ở đây là cho phần thống kê doanh thu )
        public List<SanPhamDoanhThu> CallThongKeDoanhThuSanPham(DateTime startTime, DateTime endTime)
        {
            string query = "SELECT * FROM dbo.fn_ThongKeDoanhThuSanPham(@startTime, @endTime)";
            DataTable dataTable = ExcuteQuery(query, new object[] { startTime, endTime });

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trả về từ truy vấn SQL.");
            }

            List<SanPhamDoanhThu> sanPhamDoanhThuList = new List<SanPhamDoanhThu>();// chuyên đổi các datatable sang list

            foreach (DataRow row in dataTable.Rows) // lặp qua từng hàng trong datatable ,  chuyển từng hàng thành 1 đối tượng sanPhamDoanhThu và thêm vào list
            {
                SanPhamDoanhThu sanPhamDoanhThu = new SanPhamDoanhThu
                {
                    MaSanPham = row["MaSanPham"].ToString(),
                    TenSanPham = row["TenSanPham"].ToString(),
                    TongTienBan = Convert.ToDecimal(row["TongTienBan"])
                };
                sanPhamDoanhThuList.Add(sanPhamDoanhThu);
            }

            return sanPhamDoanhThuList;
        }




        public List<VePhimDoanhThu> CallThongKeDoanhThuVePhim(DateTime startTime, DateTime endTime)
        {
            string query = "SELECT * FROM dbo.fn_ThongKeDoanhThuVePhim(@startTime, @endTime)";
            DataTable dataTable = ExcuteQuery(query, new object[] { startTime, endTime });

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trả về từ truy vấn SQL.");
            }

            List<VePhimDoanhThu> vePhimDoanhThuList = new List<VePhimDoanhThu>();

            foreach (DataRow row in dataTable.Rows)
            {
                VePhimDoanhThu vePhimDoanhThu = new VePhimDoanhThu
                {
                    ThoiGian = row["ThoiGian"].ToString(),
                    SoLuong = Convert.ToDecimal(row["SoLuong"]),
                    TongTienBan = Convert.ToDecimal(row["TongTienBan"])
                };
                vePhimDoanhThuList.Add(vePhimDoanhThu);
            }

            return vePhimDoanhThuList;
        }


    }
}
