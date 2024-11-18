using RapPhimFlix.Controllers;
using RapPhimFlix.Forms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RapPhimFlix.Forms
{
    public partial class frmListPhim : Form
    {
        private DataTable _phimTable = DataProvider.Instance.ExcuteQuery("select * from tblPhims");
        private string _maPhim;
        public event EventHandler<DataRow> AddButtonClicked;
        public frmListPhim()
        {
            InitializeComponent();
            //main = (display)form;
            _phimTable = DataProvider.Instance.ExcuteQuery("select * from tblPhims");
            Load();
        }

        
        private void Load()
        {
            if (_phimTable.Rows.Count > 0)
                foreach (DataRow row in _phimTable.Rows)
                {
                    ucPhim uc = new ucPhim(row["MaPhim"].ToString(), row["Ten"].ToString(), row["TenAnh"].ToString());
                    uc.AddButtonClicked += btn_Click;
                    flp_main.Controls.Add(uc);
                }
        }
        private void btn_Click(object? sender, string e)
        {
            object[] parameter = { e };
            DataTable phim = DataProvider.Instance.ExcuteQuery("select * from tblPhims where MaPhim = @MaPhim", parameter);
            AddButtonClicked?.Invoke(this, phim.Rows[0]);
        }
    }
}
