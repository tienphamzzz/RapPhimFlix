namespace RapPhimFlix.Forms.MenuNav
{
    partial class Form_DanhSachPhim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grb_Phim = new GroupBox();
            btn_Phim_Them = new Button();
            btn_Phim_Xoa = new Button();
            btn_Phim_Sua = new Button();
            btn_Phim_ChiTiet = new Button();
            dgv_SanPham = new DataGridView();
            grb_Phim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).BeginInit();
            SuspendLayout();
            // 
            // grb_Phim
            // 
            grb_Phim.Controls.Add(btn_Phim_Them);
            grb_Phim.Controls.Add(btn_Phim_Xoa);
            grb_Phim.Controls.Add(btn_Phim_Sua);
            grb_Phim.Controls.Add(btn_Phim_ChiTiet);
            grb_Phim.Dock = DockStyle.Bottom;
            grb_Phim.Location = new Point(0, 350);
            grb_Phim.Name = "grb_Phim";
            grb_Phim.Size = new Size(800, 100);
            grb_Phim.TabIndex = 1;
            grb_Phim.TabStop = false;
            // 
            // btn_Phim_Them
            // 
            btn_Phim_Them.Location = new Point(135, 34);
            btn_Phim_Them.Name = "btn_Phim_Them";
            btn_Phim_Them.Size = new Size(95, 33);
            btn_Phim_Them.TabIndex = 4;
            btn_Phim_Them.Text = "Thêm";
            btn_Phim_Them.UseVisualStyleBackColor = true;
            btn_Phim_Them.Click += btn_Phim_Them_Click;
            // 
            // btn_Phim_Xoa
            // 
            btn_Phim_Xoa.Location = new Point(415, 34);
            btn_Phim_Xoa.Name = "btn_Phim_Xoa";
            btn_Phim_Xoa.Size = new Size(98, 33);
            btn_Phim_Xoa.TabIndex = 3;
            btn_Phim_Xoa.Text = "Xóa";
            btn_Phim_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_Phim_Sua
            // 
            btn_Phim_Sua.Location = new Point(265, 34);
            btn_Phim_Sua.Name = "btn_Phim_Sua";
            btn_Phim_Sua.Size = new Size(98, 33);
            btn_Phim_Sua.TabIndex = 2;
            btn_Phim_Sua.Text = "Sửa";
            btn_Phim_Sua.UseVisualStyleBackColor = true;
            btn_Phim_Sua.Click += btn_Phim_Sua_Click;
            // 
            // btn_Phim_ChiTiet
            // 
            btn_Phim_ChiTiet.Location = new Point(12, 34);
            btn_Phim_ChiTiet.Name = "btn_Phim_ChiTiet";
            btn_Phim_ChiTiet.Size = new Size(95, 33);
            btn_Phim_ChiTiet.TabIndex = 0;
            btn_Phim_ChiTiet.Text = "Chi Tiết";
            btn_Phim_ChiTiet.UseVisualStyleBackColor = true;
            btn_Phim_ChiTiet.Click += btn_Phim_ChiTiet_Click;
            // 
            // dgv_SanPham
            // 
            dgv_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham.Dock = DockStyle.Fill;
            dgv_SanPham.Location = new Point(0, 0);
            dgv_SanPham.Name = "dgv_SanPham";
            dgv_SanPham.Size = new Size(800, 450);
            dgv_SanPham.TabIndex = 2;
            // 
            // Form_DanhSachPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grb_Phim);
            Controls.Add(dgv_SanPham);
            Name = "Form_DanhSachPhim";
            Text = "Form_DanhSachPhim";
            grb_Phim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox grb_Phim;
        private DataGridView dgv_SanPham;
        private Button button2;
        private Button button1;
        private Button btn_Phim_ChiTiet;
        private Button btn_Phim_Xoa;
        private Button btn_Phim_Sua;
        private Button btn_Phim_Them;
    }
}