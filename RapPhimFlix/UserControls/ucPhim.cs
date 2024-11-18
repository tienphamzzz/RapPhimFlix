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

namespace RapPhimFlix.Forms.UserControls
{
    public partial class ucPhim : UserControl
    {
        private string _maPhim;
        private string _tenPhim;
        private string _tenAnh;
        public event EventHandler<string> AddButtonClicked;
        public ucPhim()
        {
            InitializeComponent();
        }
        public ucPhim(string maPhim, string tenPhim, string tenAnh)
        {
            InitializeComponent();
            _tenAnh = tenAnh;
            _maPhim = maPhim;
            _tenPhim = tenPhim;
            Hehe_Load();
        }
        private void Hehe_Load()
        {
            ExportFile.loadImage(ptb_HienThi, "Resources\\images\\phims", _tenAnh);
            btn_Them.Text = $"Them\n{_maPhim}";
            grb_HienThi.Text = _tenPhim;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, _maPhim);
        }
        
    }
}
