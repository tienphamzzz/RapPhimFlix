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
    public partial class frmListPhim2 : UserControl
    {

        public DataTable _phim;

        public frmListPhim2()
        {
            InitializeComponent();
            //main = (display)form;
            _phim = DataProvider.Instance.ExcuteQuery("select * from tblPhims");
        }

        private void frmListPhim2_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                loadbox();
            }
        }
        private void loadbox()
        {
            GroupBox grb = new GroupBox();
            Button btn = new Button();
            PictureBox ptb = new PictureBox();
            grb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb).BeginInit();
            // groupbox
            grb.Controls.Add(btn);
            grb.Controls.Add(ptb);
            grb.Location = new Point(22, 30);
            grb.Name = "grb_HienThi1";
            grb.Size = new Size(140, 210);
            grb.TabIndex = 0;
            grb.TabStop = false;
            grb.Text = "ten-phim";
            // button
            btn.Location = new Point(30, 181);
            btn.Name = "btn_Them1";
            btn.Size = new Size(75, 23);
            btn.TabIndex = 1;
            btn.Text = "Thêm";
            btn.UseVisualStyleBackColor = true;
            //btn.Click += btn_Them;
            //picturebox
            ptb.Location = new Point(6, 14);
            ptb.Name = "ptb_HienThi2";
            ptb.Size = new Size(128, 161);
            ptb.TabIndex = 0;
            ptb.TabStop = false;
        }
    }
}
