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
    public partial class Ql_TaiKhoan : Form
    {
        Controllers.DataContext dtbase = new Controllers.DataContext();
        public Ql_TaiKhoan()
        {
            InitializeComponent();
            loaddata();
        }

        void loaddata()
        {

            try
            {
                string sql = "SELECT * FROM tblNhanvien";
                DataTable dt = dtbase.ReadData(sql);
                dtgv_ThongTinNV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dtgv_ThongTinNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                string maNhanVien = dtgv_ThongTinNV.CurrentRow.Cells[0].Value.ToString(); // Giả sử cột "MaNhanVien" là khóa chính

                // Mở form ChiTietNV và truyền dữ liệu
                ChiTietNV chiTietNVForm = new ChiTietNV(maNhanVien);
                chiTietNVForm.ShowDialog();
            }
        }

        private void btn_TimMaNV_Click(object sender, EventArgs e)
        {
            if (txt_TimMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào ô tìm kiếm nhân viên!");
                return;
            }
            else
            {
                for (int i = 0; i <= dtgv_ThongTinNV.Rows.Count - 1; i++)
                {
                    if (dtgv_ThongTinNV.Rows[i].Cells[0].Value.ToString() == txt_TimMaNV.Text || dtgv_ThongTinNV.Rows[i].Cells[2].Value.ToString() == txt_TimMaNV.Text)
                    {
                        dtgv_ThongTinNV.Rows[i].Selected = true;
                        dtgv_ThongTinNV.CurrentCell = dtgv_ThongTinNV.Rows[i].Cells[0];
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!", "thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }


            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemNV themNV = new ThemNV();
            if (themNV.ShowDialog() == DialogResult.OK)
            {
                loaddata(); // Gọi lại phương thức loaddata() để cập nhật dữ liệu
            }

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (dtgv_ThongTinNV.CurrentRow != null)
            {
                string maNhanVien = dtgv_ThongTinNV.CurrentRow.Cells[0].Value.ToString(); // Giả sử cột "MaNhanVien" là khóa chính
                SuaNV suaNVForm = new SuaNV(maNhanVien);
                if (suaNVForm.ShowDialog() == DialogResult.OK)
                {
                    loaddata(); // Gọi lại phương thức loaddata() để cập nhật dữ liệu
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dtgv_ThongTinNV.CurrentRow != null)
            {
                string maNhanVien = dtgv_ThongTinNV.CurrentRow.Cells[0].Value.ToString(); 

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Xóa dữ liệu từ cơ sở dữ liệu
                    string sqlNhanVien = "DELETE FROM tblNhanVien WHERE MaNhanVien = '"+ maNhanVien +"';";
                    string sqlTaiKhoan = "DELETE FROM tblTaiKhoan WHERE MaNhanVien = '"+ maNhanVien +"';";

                     dtbase.ChangeData(sqlNhanVien);
                     dtbase.ChangeData(sqlTaiKhoan);

                    
                        MessageBox.Show("Xóa thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loaddata(); 

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        


    }
    }
}
