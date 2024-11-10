using RapPhimFlix.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms
{
    public partial class frmSuatChieu : UserControl
    {
        private DataTable _suatChieuPhim;
        private DataContext _context;
        private string MaPhim;
        private display main;
        public frmSuatChieu(string MaPhim, Form main)
        {
            InitializeComponent();
            this.MaPhim = MaPhim;
            this.main = (display)main;
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
            {
                cbo_CacCaChieuKhac.Visible = true;
                btn_Chon.Visible = true;
                btn_Chon.Text = "Chọn";
            }
            else if (cbo_CacCaChieuKhac.SelectedIndex == -1)
            {
                cbo_CacCaChieuKhac.Visible = false;
                btn_Chon.Visible = false;
            }
        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            label1.Text = btn.Text;
        }

        private void frmSuatChieu_Load(object sender, EventArgs e)
        {
            rtb_ThongTinPhim.BorderStyle = BorderStyle.None;
            rtb_ThongTinPhim.SelectionIndent = 0;
            rtb_ThongTinPhim.SelectionHangingIndent = 0;
            _context = new DataContext();
            _suatChieuPhim = _context.ReadData("select * from tblPhims inner join tblSuatChieu on tblPhims.MaPhim = tblSuatChieu.MaPhim where tblPhims.MaPhim = " + "N'" + MaPhim + "' order by tblSuatChieu.CaChieu asc");
            if (_suatChieuPhim.Rows.Count > 0) GanCacBox();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            if (cbo_CacCaChieuKhac.SelectedIndex != -1)
            {
                Match match = Regex.Match(cbo_CacCaChieuKhac.Text, @"Ca:\s*(\d+-\d+).*Ngay Chieu:\s*(\d{4}-\d{2}-\d{2})");
                if (match.Success)
                    btn_Chon.Text = match.Groups[1].Value + '\n' + match.Groups[2].Value;
                cbo_CacCaChieuKhac.SelectedIndex = -1;
                btn_click(sender, e);
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            main.ShowUserControl(new frmListPhim(main));
        }
    }
}
