using RapPhimFlix.Forms.MenuNav.SanPham;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix.Forms.MenuNav.SuatChieu
{
    public partial class Form_DanhSachSuatChieu : Form
    {
        private FormQuanLy formQLy;
        public Form_DanhSachSuatChieu(FormQuanLy formQuanLy)
        {
            InitializeComponent();
            this.formQLy = formQuanLy;
        }

        private void btn_SuatChieu_Them_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_SuatChieu_Them());
        }

        private void btn_SuatChieu_Sua_Click(object sender, EventArgs e)
        {
            formQLy.OpenFormChild(new Form_SuatChieu_Sua());
        }
    }
}
