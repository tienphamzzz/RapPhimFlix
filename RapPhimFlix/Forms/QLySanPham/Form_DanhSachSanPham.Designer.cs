namespace RapPhimFlix.Forms.MenuNav.SanPham
{
    partial class Form_DanhSachSanPham
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
            btn_SanPham_Them = new Button();
            btn_SanPham_Xoa = new Button();
            btn_SanPham_Sua = new Button();
            btn_SanPham_ChiTiet = new Button();
            dataGridView1 = new DataGridView();
            grb_Phim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // grb_Phim
            // 
            grb_Phim.Controls.Add(btn_SanPham_Them);
            grb_Phim.Controls.Add(btn_SanPham_Xoa);
            grb_Phim.Controls.Add(btn_SanPham_Sua);
            grb_Phim.Controls.Add(btn_SanPham_ChiTiet);
            grb_Phim.Dock = DockStyle.Bottom;
            grb_Phim.Location = new Point(0, 350);
            grb_Phim.Name = "grb_Phim";
            grb_Phim.Size = new Size(800, 100);
            grb_Phim.TabIndex = 2;
            grb_Phim.TabStop = false;
            // 
            // btn_SanPham_Them
            // 
            btn_SanPham_Them.Location = new Point(135, 34);
            btn_SanPham_Them.Name = "btn_SanPham_Them";
            btn_SanPham_Them.Size = new Size(95, 33);
            btn_SanPham_Them.TabIndex = 4;
            btn_SanPham_Them.Text = "Thêm";
            btn_SanPham_Them.UseVisualStyleBackColor = true;
            btn_SanPham_Them.Click += btn_SanPham_Them_Click;
            // 
            // btn_SanPham_Xoa
            // 
            btn_SanPham_Xoa.Location = new Point(415, 34);
            btn_SanPham_Xoa.Name = "btn_SanPham_Xoa";
            btn_SanPham_Xoa.Size = new Size(98, 33);
            btn_SanPham_Xoa.TabIndex = 3;
            btn_SanPham_Xoa.Text = "Xóa";
            btn_SanPham_Xoa.UseVisualStyleBackColor = true;
            // 
            // btn_SanPham_Sua
            // 
            btn_SanPham_Sua.Location = new Point(265, 34);
            btn_SanPham_Sua.Name = "btn_SanPham_Sua";
            btn_SanPham_Sua.Size = new Size(98, 33);
            btn_SanPham_Sua.TabIndex = 2;
            btn_SanPham_Sua.Text = "Sửa";
            btn_SanPham_Sua.UseVisualStyleBackColor = true;
            btn_SanPham_Sua.Click += btn_SanPham_Sua_Click;
            // 
            // btn_SanPham_ChiTiet
            // 
            btn_SanPham_ChiTiet.Location = new Point(12, 34);
            btn_SanPham_ChiTiet.Name = "btn_SanPham_ChiTiet";
            btn_SanPham_ChiTiet.Size = new Size(95, 33);
            btn_SanPham_ChiTiet.TabIndex = 0;
            btn_SanPham_ChiTiet.Text = "Chi Tiết";
            btn_SanPham_ChiTiet.UseVisualStyleBackColor = true;
            btn_SanPham_ChiTiet.Click += btn_SanPham_ChiTiet_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 350);
            dataGridView1.TabIndex = 3;
            // 
            // Form_DanhSachSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(grb_Phim);
            Name = "Form_DanhSachSanPham";
            Text = "Form_DanhSachSanPham";
            grb_Phim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_Phim;
        private Button btn_SanPham_Them;
        private Button btn_SanPham_Xoa;
        private Button btn_SanPham_Sua;
        private Button btn_SanPham_ChiTiet;
        private DataGridView dataGridView1;
    }
}