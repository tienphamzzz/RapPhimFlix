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
            ((System.ComponentModel.ISupportInitialize)dgv_Phim).BeginInit();
            SuspendLayout();
            // 
            // dgv_Phim
            // 
            dgv_Phim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Phim.Dock = DockStyle.Fill;
            dgv_Phim.Location = new Point(0, 0);
            dgv_Phim.Name = "dgv_Phim";
            dgv_Phim.Size = new Size(800, 450);
            dgv_Phim.TabIndex = 2;
            dgv_Phim.CellClick += dgv_SanPham_CellClick;
            // 
            // Form_DanhSachPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_Phim);
            Name = "Form_DanhSachPhim";
            Text = "Form_DanhSachPhim";
            ((System.ComponentModel.ISupportInitialize)dgv_Phim).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dgv_Phim;
        private Button button2;
        private Button button1;
    }
}
