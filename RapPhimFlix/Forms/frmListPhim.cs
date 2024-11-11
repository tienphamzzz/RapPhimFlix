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
    public partial class frmListPhim : Form
    {

        private string _maPhim = "";
        private display main;
        public string MaPhim { get { return _maPhim; } }
        public DataTable _phim;
        public frmListPhim(Form form)
        {
            InitializeComponent();
            main = (display)form;
            _phim = DataProvider.Instance.ExcuteQuery("select * from tblPhims");
        }

        private void btn_Them(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            _maPhim = (btn.Text.Split('\n')[1]);
            
        }

        private void frmListPhim_Load(object sender, EventArgs e)
        {
            if (_phim != null)
            {
                int i = 0;
                while (i < _phim.Rows.Count)
                {
                    DataRow bangTam = _phim.Rows[i];
                    Button btn = this.Controls.Find($"btn_Them{i + 1}", true).FirstOrDefault() as Button;
                    PictureBox ptb = this.Controls.Find($"ptb_HienThi{i + 1}", true).FirstOrDefault() as PictureBox;
                    GroupBox grb = this.Controls.Find($"grb_HienThi{i + 1}", true).FirstOrDefault() as GroupBox;
                    if (btn != null)
                        loadbtn(btn, bangTam["MaPhim"].ToString());
                    if (ptb != null)
                        loadImage(ptb, bangTam["TenAnh"].ToString());
                    if (grb != null)
                        loadgrb(grb, bangTam["Ten"].ToString());
                    i++;
                }
                if (i <= 9)
                {
                    i++;
                    for (int j = i; j <= 10; j++)
                    {
                        PictureBox ptb = this.Controls.Find($"ptb_HienThi{j}", true).FirstOrDefault() as PictureBox;
                        Button btn = this.Controls.Find($"btn_Them{j}", true).FirstOrDefault() as Button;
                        if (btn != null) btn.Enabled = false;
                        if (ptb != null) loadImage(ptb, "No Infomation.jpg");
                    }
                }
            }
        }
        private void loadImage(PictureBox ptb, string nameImage)
        {
            try
            {
                ptb.SizeMode = PictureBoxSizeMode.StretchImage;
                string fullPath = Path.Combine(Application.StartupPath, $"Resources\\images\\phims\\{nameImage}");
                ptb.Image = Image.FromFile(fullPath);
            }
            catch (Exception e)
            {
                //textBox1.Text = "Lỗi lòi mắt " + e.Message;
            }
        }
        private void loadbtn(Button btn, string maPhim)
        {
            btn.Text = $"Thêm\n{maPhim}";
            btn.Enabled = true;
        }
        private void loadgrb(GroupBox grb, string tenPhim)
        {
            grb.Text = tenPhim;
        }
    }
}
