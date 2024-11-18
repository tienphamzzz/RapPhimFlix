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
        public event EventHandler<string> AddButtonClicked;//< kiểu dữ liệu sự kiện> khai báo sự kiện ( được dùng khi click vào button thêm)
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
        private void Hehe_Load()// cập nhật giao diện và hiển thị thông tin phim
        {
            ExportFile.loadImage(ptb_HienThi, _tenAnh);// tải và hiển thị ảnh trong picturebox
            btn_Them.Text = $"Them\n{_maPhim}";// để hiển thị từ thêm và mã phim bên dưới
            grb_HienThi.Text = _tenPhim;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddButtonClicked?.Invoke(this, _maPhim);
        }
        
    }
}
