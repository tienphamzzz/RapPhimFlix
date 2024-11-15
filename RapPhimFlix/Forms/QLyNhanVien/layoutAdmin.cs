using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RapPhimFlix.Forms.QLyNhanVien;

namespace RapPhimFlix.Forms.QLyNhanVien
{
    public partial class layoutAdmin : Form
    {
        public layoutAdmin()
        {
            InitializeComponent();
          

        }



        private Form currentFormChild;// khai báo biến để lưu tham chiếu đến form con hiện tại-> cho phép đóng form con hiện tại khi mở form con khác

        private void OpenChildForm(Form childForm)// để mở form con mới và hiển thị  trong panel trên form cha
        {
            if (currentFormChild != null)// nếu form con cũ đang hiển thị thì đóng nó trước để mở form con mới
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm; // gán form con mới vào biến form con hiện tại
            childForm.TopLevel = false; // cho phép form con hoạt ddoongjj như control trong panel và không phải là cửa sổ độc lập 
            childForm.FormBorderStyle = FormBorderStyle.None; // bỏ viền form con -> khiến form còn hòa vào panel
            childForm.Dock = DockStyle.Fill; // form con chiếm toàn bộ không gian của ppanle
            pnl_Body.Controls.Add(childForm); // thêm form con vào panel
            pnl_Body.Tag = childForm; // gán tham chiếu của form con vào tag của panel
            childForm.BringToFront();// đưa form con lên trước_> đảm bảo không form nào che 
            childForm.Show(); // hiển thị form con
        }

        private void btn_QlTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Ql_TaiKhoan());
            lbl_HienThiChucNang.Text = btn_QlTaiKhoan.Text;
        }

        private void btn_ThongKeDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThongKeDoanhThu());
        }

        private void btn_thu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new thu());
        }
    }
}
