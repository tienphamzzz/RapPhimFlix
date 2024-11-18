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

namespace RapPhimFlix.Forms.MenuNav.SanPham
{
    public partial class Form_Phim_ChiTiet : Form
    {
        private FormQuanLy formQLy;
        
        private string index;
        public Form_Phim_ChiTiet(FormQuanLy formQLy, string id)
        {
            InitializeComponent();
            this.formQLy = formQLy;
            this.index = id;

            Load();
        }

        private void Load()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("select * from tblPhims where MaPhim ='" + index + "'");
            tb_ChiTietPhim_MaPhim.Enabled = false;
            tb_ChiTietPhim_DaoDien.Enabled = false;
            tb_ChiTietPhim_MoTa.Enabled = false;
            dateTimePicker1.Enabled = false;
            tb_ChiTietPhim_ThoiLuong.Enabled = false;
            tb_ChiTietPhim_QuocGia.Enabled = false;
            tb_ChiTietPhim_Tenphim.Enabled = false;
            cbb_ChiTietPhim_TheLoai.Enabled = false;
            //combobox
            DataTable dt1 = DataProvider.Instance.ExcuteQuery(" select a.Loai from tblTheLoai as a  join tblTheLoai_Phim as b on a.MaTheLoai=b.MaTheLoai where b.MaPhim='" + index + "'");
            cbb_ChiTietPhim_TheLoai.Text = dt1.Rows[0]["Loai"].ToString();
            tb_ChiTietPhim_MaPhim.Text = dt.Rows[0]["MaPhim"].ToString();

            tb_ChiTietPhim_Tenphim.Text = dt.Rows[0]["Ten"].ToString();
            tb_ChiTietPhim_DaoDien.Text = dt.Rows[0]["DaoDien"].ToString();
            tb_ChiTietPhim_MoTa.Text = dt.Rows[0]["MoTa"].ToString();
            DateTime namPH = Convert.ToDateTime(dt.Rows[0]["NamPhatHanh"].ToString());
            dateTimePicker1.Value = namPH;
            //ptB_ChiTiet_Anh.ImageLocation = dt.Rows[0]["TenAnh"].ToString();
            tb_ChiTietPhim_ThoiLuong.Text = dt.Rows[0]["ThoiLuong"].ToString();
            tb_ChiTietPhim_QuocGia.Text = dt.Rows[0]["QuocGia"].ToString();
            ExportFile.loadImage(ptB_ChiTiet_Anh, dt.Rows[0]["TenAnh"].ToString());
        }

        private void btn_ChiTietPhim_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show(" Bạn muốn quay lại danh sách phim không?",
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
}
