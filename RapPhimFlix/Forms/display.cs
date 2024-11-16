using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class display : Form
    {
        public display()
        {
            InitializeComponent();
            
        }
        
        private void frmSuatChieu1_Load(object sender, EventArgs e)
        {
           // UserControl user = new frmListPhim(this);
           // ShowUserControl(user);
        }
        public void ShowUserControl(UserControl user)
        {
            this.Controls.Clear();
            this.Controls.Add(user);
            user.Dock = DockStyle.Fill;
            //user.TabIndex = 0;
            
        }
    }
}
