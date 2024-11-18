namespace RapPhimFlix.Forms.QLyPhim

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
            dgv_Phim = new DataGridView();
            panel1 = new Panel();
            txt_TimKiem = new TextBox();
            btn_TimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Phim).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Phim
            // 
            dgv_Phim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Phim.Dock = DockStyle.Fill;
            dgv_Phim.Location = new Point(0, 43);
            dgv_Phim.Name = "dgv_Phim";
            dgv_Phim.Size = new Size(800, 407);
            dgv_Phim.TabIndex = 1;
            dgv_Phim.CellClick += dgv_SanPham_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_TimKiem);
            panel1.Controls.Add(btn_TimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 43);
            panel1.TabIndex = 0;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(214, 12);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(342, 23);
            txt_TimKiem.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(562, 11);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(75, 23);
            btn_TimKiem.TabIndex = 0;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // Form_DanhSachPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Phim);
            Controls.Add(panel1);
            Name = "Form_DanhSachPhim";
            Text = "Form_DanhSachPhim";
            ((System.ComponentModel.ISupportInitialize)dgv_Phim).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dgv_Phim;
        private Button button2;
        private Button btn_TimKiem;
        private Panel panel1;
        private TextBox txt_TimKiem;
    }
}
