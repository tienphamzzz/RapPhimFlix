using RapPhimFlix.Controllers;
using RapPhimFlix.Forms.QLyPhim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms.MenuNav.ThongTinPhim
{
    public partial class Form_Phim_Sua : Form
    {
        bool check = false;
        private FormQuanLy formQLy;
        
        private string index;
        int cntTheLoai;
        string tl;
        string matl;
        public Form_Phim_Sua(FormQuanLy formQLy, string id)
        {
            InitializeComponent();
            this.formQLy = formQLy;
            this.index = id;
            DataTable dtb = DataProvider.Instance.ExcuteQuery("select Loai from tblTheLoai");

            for (int i = 0; i < dtb.Rows.Count; i++)
            {
                cbb_SuaPhim_TheLoai.Items.Add(dtb.Rows[i]["Loai"].ToString());
            }
            DataTable dt = DataProvider.Instance.ExcuteQuery("select * from tblPhims where MaPhim ='" + id + "'");
            
            //combobox
            DataTable dt1 = DataProvider.Instance.ExcuteQuery(" select a.Loai,a.MaTheLoai from tblTheLoai as a  join tblTheLoai_Phim as b on a.MaTheLoai=b.MaTheLoai where b.MaPhim='" + id + "'");
            cbb_SuaPhim_TheLoai.Text = dt1.Rows[0]["Loai"].ToString();
            tb_SuaPhim_MaPhim.Text = dt.Rows[0]["MaPhim"].ToString();
            tl = dt1.Rows[0]["Loai"].ToString();
            matl = dt1.Rows[0]["MaTheLoai"].ToString();
            tb_SuaPhim_Tenphim.Text = dt.Rows[0]["Ten"].ToString();
            tb_SuaPhim_DaoDien.Text = dt.Rows[0]["DaoDien"].ToString();
            tb_SuaPhim_MoTa.Text = dt.Rows[0]["MoTa"].ToString();
            DateTime namPH = Convert.ToDateTime(dt.Rows[0]["NamPhatHanh"].ToString());
            dateTimePicker1.Value = namPH;
            ExportFile.loadImage(ptB_Sua_Anh, "Resources\\images\\phims", dt.Rows[0]["TenAnh"].ToString());
            tb_SuaPhim_ThoiLuong.Text = dt.Rows[0]["ThoiLuong"].ToString();
            tb_SuaPhim_QuocGia.Text = dt.Rows[0]["QuocGia"].ToString();
            
        }

        private void btn_SuaPhim_XacNhan_Click(object sender, EventArgs e)
        {

            string maPhim = tb_SuaPhim_MaPhim.Text;
            string tenPhim = tb_SuaPhim_Tenphim.Text;
            string daoDien = tb_SuaPhim_DaoDien.Text;
            string moTa = tb_SuaPhim_MoTa.Text;

            DateTime ngayChieu = dateTimePicker1.Value;
            string namPhatHanh = ngayChieu.ToString("yyyy-MM-dd");
            string thoiLuong = tb_SuaPhim_ThoiLuong.Text;
            string quocGia = tb_SuaPhim_QuocGia.Text;
            string theLoai = cbb_SuaPhim_TheLoai.Text;
            string Anh = tb_SuaPhim_Tenphim.Text;
            // Kiểm tra nếu bất kỳ trường nào bị bỏ trống
            if (string.IsNullOrWhiteSpace(maPhim) || string.IsNullOrWhiteSpace(tenPhim) ||
                string.IsNullOrWhiteSpace(daoDien) || string.IsNullOrWhiteSpace(moTa) ||
                string.IsNullOrWhiteSpace(thoiLuong) ||
                string.IsNullOrWhiteSpace(quocGia) || string.IsNullOrWhiteSpace(theLoai))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dtb1 = DataProvider.Instance.ExcuteQuery("select Loai from tblTheLoai");
            DataTable cb = DataProvider.Instance.ExcuteQuery("select * from tblTheLoai where Loai = N'" + theLoai + "'");
            cntTheLoai = dtb1.Rows.Count;
            if (cb.Rows.Count == 0 )
            {
                
                int rs = DataProvider.Instance.ExcuteNonQuery("insert into tblTheLoai(MaTheLoai,Loai) values('TL" + (cntTheLoai + 1).ToString() + "',N'" + theLoai + "')");
                if (rs!=0)
                {
                    MessageBox.Show("Thêm thể loại lỗi!");
                }
                them_theloai();
            }
            // Nếu có thay đổi ở cbb thi xóa gia trong THeLoai_Phim cu thay = cặp giá trị mới 
            else
            {
                if (theLoai != tl)
                {
                    string deleteQuery = "DELETE FROM tblTheLoai_Phim WHERE MaPhim = '" + maPhim + "' AND MaTheLoai = '"+matl+"'";

                    // Thực hiện xóa trước khi thêm dữ liệu mới
                    int deleteResult = DataProvider.Instance.ExcuteNonQuery(deleteQuery);
                    int rs1 = DataProvider.Instance.ExcuteNonQuery("insert into tblTheLoai_Phim (MaPhim,MaTheLoai) values('" + maPhim + "','" + cb.Rows[0]["MaTheLoai"].ToString() + "')");

                }
            }

            // cap nhat vao db
            string updateQuery = $"UPDATE tblPhims SET Ten = N'{tenPhim}', DaoDien = N'{daoDien}', MoTa = N'{moTa}', NamPhatHanh = '{namPhatHanh}', ThoiLuong = '{thoiLuong}', QuocGia = N'{quocGia}', TenAnh = '{Anh}' WHERE MaPhim = '{maPhim}'";
            //cap nhat bang TheLoai_phim

            int result = DataProvider.Instance.ExcuteNonQuery(updateQuery);

            if (result!=0)
            {
                check = true;
                ExportFile.saveImage(ptB_Sua_Anh, "Resources\\images\\phims", Anh);
                MessageBox.Show("Cập nhật phim thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Cập nhật phim thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Phim_SuaAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Chọn tệp cần mở";               // Tiêu đề hộp thoại
            open.Filter = "Tệp ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif"; // Bộ lọc
            open.Multiselect = false;                    // Cho phép chọn nhiều tệp (true/false)
            open.InitialDirectory = "C:\\Users\\Administrator\\source\\repos\\RapPhimFlix\\RapPhimFlix\\Resources";
            string selectedFilePath = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = open.FileName;
            }
            if (selectedFilePath != "")
            {
                ptB_Sua_Anh.ImageLocation = selectedFilePath;
            }
        }

        private void btn_SuaPhim_quaylai_Click(object sender, EventArgs e)
        {
            if (check == true)
            {
                formQLy.OpenFormChild(new Form_DanhSachPhim(formQLy));
                formQLy.hien_thanhButton();
            }
            else
            {
                DialogResult result1 = MessageBox.Show("Bạn chưa hoàn tất sửa ! Bạn muốn quay lại danh sách phim không?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {
                    formQLy.OpenFormChild(new Form_DanhSachPhim(formQLy));
                    formQLy.hien_thanhButton();
                }
            }
        }
        public void them_theloai()
        {
            string loai = "";
            if (cbb_SuaPhim_TheLoai.Text != null)
            {
                loai = cbb_SuaPhim_TheLoai.Text;
            }
            else
            {
                MessageBox.Show("van null");
            }
            // Đọc dữ liệu và kiểm tra kết quả
            string query = "Select MaTheLoai from tblTheLoai where Loai = N'" + loai + "'";
            DataTable dt1 = DataProvider.Instance.ExcuteQuery(query);
            string Ma_Phim = tb_SuaPhim_MaPhim.Text;
            if (dt1.Rows.Count > 0)
            {
                string MaTheloai = dt1.Rows[0]["MaTheLoai"].ToString();


                // Tạo câu truy vấn

                int result = DataProvider.Instance.ExcuteNonQuery("insert into tblTheLoai_Phim (MaPhim,MaTheLoai) values('" + Ma_Phim + "','" + MaTheloai + "')");

                if (result!=0)
                {
                    MessageBox.Show("Thêm dữ liệu thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("them the loai loi");
            }
        }

    }
}

