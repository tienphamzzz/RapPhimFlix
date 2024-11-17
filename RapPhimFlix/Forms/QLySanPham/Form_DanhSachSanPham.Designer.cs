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
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).BeginInit();
            SuspendLayout();
            // 
            // dgv_SanPham
            // 
            dgv_SanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_SanPham.Dock = DockStyle.Fill;
            dgv_SanPham.Location = new Point(0, 0);
            dgv_SanPham.Name = "dgv_SanPham";
            dgv_SanPham.Size = new Size(800, 450);
            dgv_SanPham.TabIndex = 3;
            dgv_SanPham.CellClick += dgv_SanPham_CellClick;
            // 
            // Form_DanhSachSanPham
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_SanPham);
            Name = "Form_DanhSachSanPham";
            Text = "Form_DanhSachSanPham";
            ((System.ComponentModel.ISupportInitialize)dgv_SanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_SanPham;
    }
}