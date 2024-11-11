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
        private Form main;
        public frmPhongChieu()
        {
            InitializeComponent();

        }

        private void btn_QuayLai_Click(object sender, EventArgs e)
        {

        }
        public void MakePanelCircular(Panel panel)
        {
            // Tạo một GraphicsPath với hình tròn có kích thước như panel
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, panel.Width, panel.Height);

            // Đặt vùng hiển thị của panel là hình tròn vừa tạo
            panel.Region = new Region(path);
        }

        private void frmPhongChieu_Load(object sender, EventArgs e)
        {
            MakePanelCircular(panel_Cua1);
            MakePanelCircular(panel_Cua2);
        }
    }
}
