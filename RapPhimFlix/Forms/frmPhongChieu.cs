using RapPhimFlix.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms
{
    public partial class frmPhongChieu : Form
    {
        private DataRow _suatChieu;
        private DataRow _phim;
        private DataRow _phongChieu;
        private DataTable _ghes;
        private List<string> _listGhesSelected = new List<string>();
        public event EventHandler<DataRow> AddButtonQuayLaiClicked;

        public event EventHandler<Pair<DataRow, List<string>>> AddButtonClicked;
        public frmPhongChieu(DataRow suatChieu)
        {
            InitializeComponent();
            _suatChieu = suatChieu;
            object[] prPhim = { _suatChieu["MaPhim"].ToString() };
            _phim = DataProvider.Instance.ExcuteQuery("select * from tblPhims where MaPhim = @MaPhim", prPhim).Rows[0];
            object[] prPhongChieu = { _suatChieu["MaPhongChieu"].ToString() };
            _phongChieu = DataProvider.Instance.ExcuteQuery("select * from tblPhongChieu where MaPhongChieu = @MaPhongChieu", prPhongChieu).Rows[0];
            Load();
        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {
            AddButtonQuayLaiClicked?.Invoke(this, _phim);
        }
        public void MakePanelCircular(Panel panel)
        {
            // Tạo một GraphicsPath với hình tròn có kích thước như panel
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, panel.Width, panel.Height);

            // Đặt vùng hiển thị của panel là hình tròn vừa tạo
            panel.Region = new Region(path);
        }

        private async Task Load()
        {
            MakePanelCircular(panel_Cua1);
            MakePanelCircular(panel_Cua2);
            lbl_Phong.Text += $" {_phongChieu["TenPhong"].ToString()}";
            lbl_ThoiGian.Text += $" {_suatChieu["CaChieu"].ToString()} giờ";
            lbl_GiaVe.Text += $"{_suatChieu["GiaVe"].ToString()} đồng";
            await TaoGhe();
            btn_TiepTheo.Enabled = false;
        }
        private async Task TaoGhe()
        {
            for (int i = 1; i <= 12; i++)
                for (int j = 1; j <= 10; j++)
                {
                    Button btn = this.Controls.Find($"btn_{tagOfLbl(i)}{j}", true).FirstOrDefault() as Button;
                    if (btn != null)
                    {
                        btn.Tag = $"{_suatChieu["MaSuatChieu"].ToString()}-{_phongChieu["MaPhongChieu"].ToString()}-{tagOfLbl(i)}{j}";
                        MauBtn(btn);
                        //ExportFile.loadIconButotn(btn, "iconchair.jpg");
                    }
                }
        }
        private void MauBtn(Button btn)
        {
            object[] pr = { btn.Tag.ToString() };
            DataTable check = DataProvider.Instance.ExcuteQuery("select * from tblGhes where MaGhe = @MaGhe", pr);
            if (check.Rows.Count > 0)
                if (check.Rows[0]["TrangThai"].ToString() == "True")
                    DoiMauGhe(btn, true);
                else DoiMauGhe(btn, false);
        }
        private string tagOfLbl(int tag)
        {
            switch (tag)
            {
                case 1: return "A";
                case 2: return "B";
                case 3: return "C";
                case 4: return "D";
                case 5: return "E";
                case 6: return "F";
                case 7: return "G";
                case 8: return "H";
                case 9: return "I";
                case 10: return "J";
                case 11: return "K";
                default: return "L";
            }
        }
        private void DoiMauGhe(Button btn, bool check)
        {
            btn.BackColor = (check) ? Color.Red : Color.Green;
            if (check)
            {
                btn.BackColor = Color.Red;
                //ExportFile.loadIconButotn(btn, "rediconchair.png");
                btn.Enabled = false;
            }
            else btn.BackColor = Color.FromArgb(128, 255, 128);
                //ExportFile.loadIconButotn(btn, "greeniconchair.png");
        }

        private void btn_ChonGhe_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Orange;
            btn_TiepTheo.Enabled = true;
            _listGhesSelected.Add(btn.Tag.ToString());
        }
        private void btn_TiepTheo_Click(object sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, new Pair<DataRow, List<string>>(_suatChieu, _listGhesSelected));
        }
    }
}
