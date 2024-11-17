using RapPhimFlix.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms
{
    public partial class frmSuatChieu : Form
    {
        private DataTable _suatChieuPhim;
        private DataRow _rowPhim;
        private DataRow[] _rows;
        public event EventHandler AddButtonQuayLayClicked;
        public event EventHandler<DataRow> AddButtonClicked;
        public frmSuatChieu(DataRow Phim)
        {
            InitializeComponent();
            _rowPhim = Phim;
            object[] pr = { _rowPhim["MaPhim"].ToString() };
            _suatChieuPhim = DataProvider.Instance.ExcuteQuery("select * from tblSuatChieu sc where sc.MaPhim = @MaPhim", pr);
            if (_suatChieuPhim.Rows.Count > 0)
            {
                lbl_TenPhim.Text = _rowPhim["Ten"].ToString();
                _rows = new DataRow[_suatChieuPhim.Rows.Count];
                Load();
            }
            
        }
        private void Load()
        {
            designRtb();
            string[] CaChieuThuc = DateTime.Now.ToString("HH:mm").Split(":");
            DateTime NgayChieuThuc = DateTime.Now;
            int i = 0;
            foreach (DataRow row in _suatChieuPhim.Rows)
            {
                Button btn = new Button();
                string[] gio = row["CaChieu"].ToString().Split("-");
                DateTime NgayChieu = (DateTime)row["NgayChieu"];
                if (NgayChieuThuc.Date < NgayChieu.Date || NgayChieuThuc.Date == NgayChieu.Date && int.Parse(CaChieuThuc[0]) < int.Parse(gio[0]))
                {
                    btn.Text = row["CaChieu"].ToString() + '\n';
                    btn.Text += NgayChieu.Date.ToString("yyyy-MM-dd");
                    btn.Tag = i;
                    btn.Size = new Size(btn.Width, btn.Height * 2);
                    addBtnInFlp(btn);
                    cbo_CacCaChieuKhac.Items.Add("Ca: " + row["CaChieu"].ToString() + " Ngay Chieu: " + NgayChieu.Date.ToString("yyyy-MM-dd"));
                }
                i++;
            }
        }
        private void addBtnInFlp(Button btn) {
            btn.Click += btn_Click;
            flp_CaChieu.Controls.Add(btn); 
        }
        private void designRtb()
        {
            rtb_ThongTinPhim.BorderStyle = BorderStyle.None;
            rtb_ThongTinPhim.SelectionIndent = 0;
            rtb_ThongTinPhim.SelectionHangingIndent = 0;

            rtb_ThongTinPhim.Text += "Thời lượng: " + _rowPhim["ThoiLuong"].ToString() + '\n';
            rtb_ThongTinPhim.Text += "Đạo diễn:   " + _rowPhim["DaoDien"].ToString() + '\n';
            ExportFile.loadImage(ptb_Anh, _rowPhim["TenAnh"].ToString());
            rtb_ThongTinPhim.Text += "Mô tả: " + ExportFile.ReadFileOrDefault(_rowPhim["MoTa"].ToString());
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
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddButtonClicked?.Invoke(this, _suatChieuPhim.Rows[(int)btn.Tag]);
        }
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            if (cbo_CacCaChieuKhac.SelectedIndex != -1)
            {
                Match match = Regex.Match(cbo_CacCaChieuKhac.Text, @"Ca:\s*(\d+-\d+).*Ngay Chieu:\s*(\d{4}-\d{2}-\d{2})");
                if (match.Success)
                {
                    btn_Chon.Text = match.Groups[1].Value + '\n' + match.Groups[2].Value;
                    btn_Chon.Tag = cbo_CacCaChieuKhac.SelectedIndex;
                }    
                cbo_CacCaChieuKhac.SelectedIndex = -1;
                btn_Click(sender, e);
            }
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            AddButtonQuayLayClicked?.Invoke(this, e);
        }

    }
}
