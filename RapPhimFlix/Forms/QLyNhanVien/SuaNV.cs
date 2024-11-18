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

namespace RapPhimFlix.Forms.QLyNhanVien
{
    public partial class SuaNV : Form
    {
        Controllers.DataContext dtbase = new Controllers.DataContext();
        Controllers.DataContext dtbase = new Controllers.DataContext();
        private string maNhanVien;
        public SuaNV(String maNhanVien)
        {
            this.maNhanVien = maNhanVien;
            InitializeComponent();
            LoadChiTietNhanVien();
        }

        private void LoadChiTietNhanVien()
        {
            try
            {
                string sql = "select nv.GioiTinh,nv.HovaTen,nv.Luong,nv.MaNhanVien,nv.SDT,tk.MatKhau,nv.ChucVu from [dbo].[tblNhanVien] nv join [dbo].[tblTaiKhoan] tk on nv.MaNhanVien=tk.MaNhanVien WHERE nv.MaNhanVien = '" + maNhanVien + "'";
                DataTable dt = DataProvider.Instance.ExcuteQuery(sql);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];

                    txt_MaNV.Text = row["MaNhanVien"].ToString();
                    txt_TenNV.Text = row["HovaTen"].ToString();
                    txt_SDT.Text = row["SDT"].ToString();
                    txt_Luong.Text = row["Luong"].ToString();
                    txt_MatKhau.Text = row["MatKhau"].ToString();
                    txt_TaiKhoan.Text = row["SDT"].ToString();

                    if (row["ChucVu"].ToString() == "1")
                    {
                        rdo_ChucVuNhanVien.Checked = true;
                    }
                    else
                    {
                        rdo_ChucVu_QuanLy.Checked = true;
                    }

                    if (row["GioiTinh"].ToString() == "Nam")
                    {
                        rdo_GioiTinh_Nam.Checked = true;
                    }
                    else
                    {
                        rdo_GioiTinh_Nu.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string maNV = txt_MaNV.Text;
            string tenNV = txt_TenNV.Text;
            string chucVu = rdo_ChucVuNhanVien.Checked ? "1" : "0";
            string sdt = txt_SDT.Text;
            string luong = txt_Luong.Text;
            string gioiTinh = rdo_GioiTinh_Nam.Checked ? "Nam" : "Nữ";
            string matKhau = txt_MatKhau.Text;
            string taiKhoan = txt_TaiKhoan.Text;

            string sqlNhanVien = "UPDATE tblNhanVien SET HovaTen = '" + tenNV + "', ChucVu = '" + chucVu + "', SDT = '" + sdt + "', Luong = '" + luong + "', GioiTinh = '" + gioiTinh + "' WHERE MaNhanVien = '" + maNV + "';";

            string sqlTaiKhoan = "UPDATE tblTaiKhoan SET MatKhau = '" + matKhau + "' WHERE MaNhanVien = '" + maNV + "';";

            DataProvider.Instance.ExcuteQuery(sqlNhanVien);
            DataProvider.Instance.ExcuteQuery(sqlTaiKhoan);
            MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK; // Đặt kết quả DialogResult là OK
            this.Close(); // Đóng form SuaNV
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
