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

namespace RapPhimFlix.Forms
{
    public partial class frmSuatChieu : Form
    {
        private DataTable _suatChieuPhim;
        private DataContext _context;
        public frmSuatChieu(string MaPhim)
        {
            InitializeComponent();
            rtb_ThongTinPhim.BorderStyle = BorderStyle.None;
            rtb_ThongTinPhim.SelectionIndent = 0;
            rtb_ThongTinPhim.SelectionHangingIndent = 0;
            _context = new DataContext();
            _suatChieuPhim = _context.ReadData("select * from tblPhims inner join tblSuatChieu on tblPhims.MaPhim = tblSuatChieu.MaPhim where tblPhims.MaPhim = " + "N'" + MaPhim + "' order by tblSuatChieu.CaChieu asc");
            if (_suatChieuPhim.Rows.Count > 0 )
            {
                GanCacBox();
            }
        }
        private void GanCacBox()
        {
            string[] CaChieuThuc = DateTime.Now.ToString("HH:mm").Split(":");
            DateTime NgayChieuThuc = DateTime.Now;
            for (int i = 1, j = 0; i <= 5 && j < _suatChieuPhim.Rows.Count; i++, j++)
            {
                Button btn = this.Controls.Find($"btn_SuatChieu{i}", true).FirstOrDefault() as Button;

                if (btn != null)
                    while (j < _suatChieuPhim.Rows.Count)
                    {
                        DataRow bangTam = _suatChieuPhim.Rows[j];
                        string[] gio = bangTam["CaChieu"].ToString().Split("-");
                        DateTime NgayChieu = (DateTime)bangTam["NgayChieu"];
                        if (NgayChieuThuc.Date < NgayChieu.Date || NgayChieuThuc.Date == NgayChieu.Date && int.Parse(CaChieuThuc[0]) < int.Parse(gio[0]))
                        {
                            btn.Text = bangTam["CaChieu"].ToString() + '\n';
                            btn.Text += NgayChieu.Date.ToString("yyyy-MM-dd");
                            j++;
                            break;
                        }
                        j++;
                    }
            }
            for (int i = 0; i < _suatChieuPhim.Rows.Count; i++)
            {
                DataRow bangTam = _suatChieuPhim.Rows[i];
                string[] gio = bangTam["CaChieu"].ToString().Split("-");
                DateTime NgayChieu = (DateTime)bangTam["NgayChieu"];
                if (NgayChieuThuc.Date < NgayChieu.Date || NgayChieuThuc.Date == NgayChieu.Date && int.Parse(CaChieuThuc[0]) < int.Parse(gio[0]))
                    cbo_CacCaChieuKhac.Items.Add("Ca: " + bangTam["CaChieu"].ToString() + " Ngay Chieu: " + NgayChieu.Date.ToString("yyyy-MM-dd"));
            }
            DataRow bang = _suatChieuPhim.Rows[0];
            lbl_TenPhim.Text = bang["Ten"].ToString();
            rtb_ThongTinPhim.Text += "Thời lượng: " + bang["ThoiLuong"].ToString() + '\n';
            rtb_ThongTinPhim.Text += "Đạo diễn:   " + bang["DaoDien"].ToString() + '\n';
            DocFile(bang["MoTa"].ToString());
            DocFile(bang["TenAnh"].ToString(), 1);
        }
        private void DocFile(string tenFile, int kieu = 0)
        {
            if (kieu == 0)
            {
                try
                {
                    string fullPath = Path.Combine(Application.StartupPath, $"Resources\\filedata\\{tenFile}");
                    // E:\Mon Hoc\ki 5\Lap trinh truc quan\Bai tap lon\Git\RapPhimFlix\RapPhimFlix\bin\Debug\net8.0-windows\Resources\filedata\
                    rtb_ThongTinPhim.Text += "Mô tả: " + File.ReadAllText(fullPath);
                }
                catch (Exception e)
                {
                    //textBox1.Text = "Lỗi lòi mắt " + e.Message;
                }
            }
            else if (kieu == 1)
            {
                try
                {
                    ptb_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
                    string fullPath = Path.Combine(Application.StartupPath, $"Resources\\images\\phims\\{tenFile}");
                    ptb_Anh.Image = Image.FromFile(fullPath);
                }
                catch (Exception e)
                {
                    //textBox1.Text = "Lỗi lòi mắt " + e.Message;
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cbo_CacCaChieuKhac.Visible == false)
                cbo_CacCaChieuKhac.Visible = true;
            else
            {
                cbo_CacCaChieuKhac.SelectedIndex = -1;
                cbo_CacCaChieuKhac.Visible = false;
            }
        }
    }
}
