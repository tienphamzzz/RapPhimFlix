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
            dgv_SanPham = new DataGridView();
            panel1 = new Panel();
            txt_TimKiem = new TextBox();
            btn_TimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_SanPham
            // 
            dgv_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham.Dock = DockStyle.Fill;
            dgv_SanPham.Location = new Point(0, 46);
            dgv_SanPham.Name = "dgv_SanPham";
            dgv_SanPham.Size = new Size(800, 404);
            dgv_SanPham.TabIndex = 3;
            dgv_SanPham.CellClick += dgv_SanPham_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_TimKiem);
            panel1.Controls.Add(btn_TimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
            panel1.TabIndex = 4;
            // 
            // txt_TimKiem
            // 
            txt_TimKiem.Location = new Point(187, 13);
            txt_TimKiem.Name = "txt_TimKiem";
            txt_TimKiem.Size = new Size(342, 23);
            txt_TimKiem.TabIndex = 3;
            // 
            // btn_TimKiem
            // 
            btn_TimKiem.Location = new Point(544, 12);
            btn_TimKiem.Name = "btn_TimKiem";
            btn_TimKiem.Size = new Size(75, 23);
            btn_TimKiem.TabIndex = 2;
            btn_TimKiem.Text = "Tìm kiếm";
            btn_TimKiem.UseVisualStyleBackColor = true;
            btn_TimKiem.Click += btn_TimKiem_Click;
            // 
            // Form_DanhSachSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_SanPham);
            Controls.Add(panel1);
            Name = "Form_DanhSachSanPham";
            Text = "Form_DanhSachSanPham";
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_SanPham;
        private Panel panel1;
        private TextBox txt_TimKiem;
        private Button btn_TimKiem;
    }
}
