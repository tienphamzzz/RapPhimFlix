using RapPhimFlix.Controllers;
using RapPhimFlix.Forms.MenuNav.SanPham;
using RapPhimFlix.Forms.MenuNav.SuatChieu;
using RapPhimFlix.Forms.MenuNav.ThongTinPhim;
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

namespace RapPhimFlix.Forms.MenuNav
{
    public partial class FormQuanLy : Form
    {
        public string Row_index;
        DataContext db = new DataContext();
        private string currentform;
        public FormQuanLy()
        {
            InitializeComponent();
            currentform = "Phim";
            btn_Qly_ChiTiet.Enabled = false;
            btn_Qly_Sua.Enabled = false;
            btn_Qly_Xoa.Enabled = false;
            grb_Phim.Visible = true;
            OpenFormChild(new Form_DanhSachPhim(this));
        }
        private Form currentFormChild;
        public void OpenFormChild(Form childForm)
        {
            //Nếu Form hiện tại đã có thì  đóng
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            gb_QuanLy_Body.Controls.Add(childForm);
            gb_QuanLy_Body.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();


        }
        public void hien_thanhButton()
        {
            off_Button();
            grb_Phim.Visible = true;
        }
        private void btn_QuanLy_SuatChieu_Click(object sender, EventArgs e)
        {
            currentform = "SuatChieu";
            grb_Phim.Visible = true;
            off_Button();
            OpenFormChild(new Form_DanhSachSuatChieu(this));
        }

        private void btn_QuanLy_Phim_Click(object sender, EventArgs e)
        {
            currentform = "Phim";
            grb_Phim.Visible = true;
            
            off_Button();
            OpenFormChild(new Form_DanhSachPhim(this));
        }

        private void btn_QuanLy_SanPham_Click(object sender, EventArgs e)
        {
            currentform = "SanPham";
            grb_Phim.Visible = true;
            off_Button();
            OpenFormChild(new Form_DanhSachSanPham(this));

        }

        private void btn_Qly_ChiTiet_Click(object sender, EventArgs e)
        {
            grb_Phim.Visible = false;
            if (currentform == "Phim")
            {
                OpenFormChild(new Form_Phim_ChiTiet(this, Row_index));
            }
            else if (currentform == "SanPham")
            {
                OpenFormChild(new Form_SanPham_ChiTiet(this, Row_index));
            }

        }
        public void open_Button()
        {
            btn_Qly_ChiTiet.Enabled = true;
            btn_Qly_Sua.Enabled = true;
            btn_Qly_Xoa.Enabled = true;
        }
        public void off_Button()
        {
            btn_Qly_ChiTiet.Enabled = false;
            btn_Qly_Sua.Enabled = false;
            btn_Qly_Xoa.Enabled = false;
        }
        public void off_fullButton()
        {
            btn_Qly_ChiTiet.Enabled = false;
            btn_Qly_Sua.Enabled = false;
            btn_Qly_Xoa.Enabled = false;
            btn_Qly_Them.Enabled = false;
        }
        private void gb_QuanLy_Body_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Qly_Sua_Click(object sender, EventArgs e)
        {
            grb_Phim.Visible = false;
            if (currentform == "Phim")
            {
                OpenFormChild(new Form_Phim_Sua(this, Row_index));
            }
            else if (currentform == "SanPham")
            {
                OpenFormChild(new Form_SanPham_Sua(this, Row_index));
            }
            else if (currentform == "SuatChieu")
            {
                OpenFormChild(new Form_SuatChieu_Sua(this,Row_index));
            }
        }
        public void vohieu_them()
        {
            btn_Qly_Them.Enabled = false;
        }
        public void off_ChiTiet()
        {
            btn_Qly_ChiTiet.Enabled = false;
        }
        private void btn_Qly_Them_Click(object sender, EventArgs e)
        {
            grb_Phim.Visible = false;
            if (currentform == "Phim")
            {
                OpenFormChild(new Form_Phim_Them(this));
            }
            else if (currentform == "SanPham")
            {
                OpenFormChild(new Form_SanPham_Them(this));
            }
            else if (currentform == "SuatChieu")
            {
                OpenFormChild(new Form_SuatChieu_Them(this));
            }
        }

        private void btn_Qly_Xoa_Click(object sender, EventArgs e)
        {
            if (currentform == "Phim")
            {
                DialogResult result1 = MessageBox.Show("Bạn có muốn xóa phim này không?",
                                       "Xác nhận",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {

                    DataTable dt = DataProvider.Instance.ExcuteQuery("select * from tblSuatChieu where MaPhim = '" + Row_index + "'");
                    if (dt.Rows.Count > 0)
                    {
                        DialogResult result2 = MessageBox.Show("Phim này đang được chiếu ? Bạn có muốn xóa không",
                                       "Xác nhận",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);
                        int rs = DataProvider.Instance.ExcuteNonQuery("delete from tblSuatChieu where MaPhim='" + Row_index + "'");
                        string deleteQuery = "DELETE FROM tblPhims WHERE MaPhim = '" + Row_index + "'";
                        int deleteResult = DataProvider.Instance.ExcuteNonQuery(deleteQuery);
                        if (deleteResult !=0&&rs!=0)
                        {
                            MessageBox.Show("Xóa Phim thành công!");
                            OpenFormChild(new Form_DanhSachPhim(this));
                        }
                        else
                        {
                            MessageBox.Show("Lỗi khi xóa phim.");
                        }
                    }
                    
                }
            }
            else if (currentform == "SanPham")
            {
                DialogResult result1 = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?",
                                       "Xác nhận",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM tblSanPham WHERE MaSanPham = '" + Row_index + "'";
                    bool deleteResult = db.ChangeData(deleteQuery);
                    if (deleteResult)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        OpenFormChild(new Form_DanhSachSanPham(this));
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm.");
                    }
                }
            }
            else if (currentform == "SuatChieu")
            {
                DialogResult result1 = MessageBox.Show("Bạn có muốn xóa suất chiếu này không?",
                                        "Xác nhận",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                if (result1 == DialogResult.Yes)
                {
                    string deleteQuery = "DELETE FROM tblSuatChieu WHERE MaSuatChieu = '" + Row_index + "'";
                    bool deleteResult = db.ChangeData(deleteQuery);
                    if (deleteResult)
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!");
                        OpenFormChild(new Form_DanhSachSuatChieu(this));
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm.");
                    }
                }
            }
        }
    }
}
