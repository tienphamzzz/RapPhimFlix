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
    public partial class Form_SanPham_ChiTiet : Form
    {
        private FormQuanLy formQLy;
       
        private string index;
        public Form_SanPham_ChiTiet(FormQuanLy formQLy, string id)
        {
            InitializeComponent();
            this.formQLy = formQLy;
            this.index = id;
            DataTable dt = DataProvider.Instance.ExcuteQuery("select * from tblSanPham where MaSanPham ='" + id + "'");
            tb_SanPham_ChiTiet_Gia.Text = dt.Rows[0]["Gia"].ToString();
            tb_SanPham_ChiTiet_Loai.Text = dt.Rows[0]["LoaiSanPham"].ToString();
            tb_SanPham_ChiTiet_MaSP.Text = dt.Rows[0]["MaSanPham"].ToString();
            tb_SanPham_ChiTiet_TenSanPham.Text = dt.Rows[0]["TenSanPham"].ToString();
            ptb_SanPham_ChiTiet.ImageLocation = dt.Rows[0]["Anh"].ToString();
            tb_SanPham_ChiTiet_Gia.Enabled = false;
            tb_SanPham_ChiTiet_Loai.Enabled = false;
            tb_SanPham_ChiTiet_MaSP.Enabled = false;

            tb_SanPham_ChiTiet_TenSanPham.Enabled = false;
        }

        private void btn_SanPham_ChiTiet_XacNhan_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show(" Bạn muốn quay lại danh sách sản phẩm không?",
                                      "Xác nhận",
                                      MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question);

            if (result1 == DialogResult.Yes)
            {

                formQLy.OpenFormChild(new Form_DanhSachSanPham(formQLy));
                formQLy.hien_thanhButton();
            }
        }

        private void tb_SanPham_ChiTiet_MaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ThemPhim_quaylai_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_DanhSachSanPham(formQLy));
            formQLy.hien_thanhButton();
        }
    }
}
