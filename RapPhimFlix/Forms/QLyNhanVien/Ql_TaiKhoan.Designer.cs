namespace RapPhimFlix.Forms.QLyNhanVien
{
    partial class Ql_TaiKhoan
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
            dtgv_ThongTinNV = new DataGridView();
            btn_TimMaNV = new Button();
            txt_TimMaNV = new TextBox();
            btn_Them = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgv_ThongTinNV).BeginInit();
            SuspendLayout();
            // 
            // dtgv_ThongTinNV
            // 
            dtgv_ThongTinNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ThongTinNV.Location = new Point(-1, 31);
            dtgv_ThongTinNV.Margin = new Padding(2, 2, 2, 2);
            dtgv_ThongTinNV.Name = "dtgv_ThongTinNV";
            dtgv_ThongTinNV.RowHeadersWidth = 62;
            dtgv_ThongTinNV.Size = new Size(704, 306);
            dtgv_ThongTinNV.TabIndex = 0;
            dtgv_ThongTinNV.CellDoubleClick += dtgv_ThongTinNV_CellDoubleClick;
            // 
            // btn_TimMaNV
            // 
            btn_TimMaNV.Location = new Point(633, 5);
            btn_TimMaNV.Margin = new Padding(2, 2, 2, 2);
            btn_TimMaNV.Name = "btn_TimMaNV";
            btn_TimMaNV.Size = new Size(70, 22);
            btn_TimMaNV.TabIndex = 1;
            btn_TimMaNV.Text = "Tìm";
            btn_TimMaNV.UseVisualStyleBackColor = true;
            btn_TimMaNV.Click += btn_TimMaNV_Click;
            // 
            // txt_TimMaNV
            // 
            txt_TimMaNV.Location = new Point(411, 4);
            txt_TimMaNV.Margin = new Padding(2, 2, 2, 2);
            txt_TimMaNV.Name = "txt_TimMaNV";
            txt_TimMaNV.Size = new Size(195, 23);
            txt_TimMaNV.TabIndex = 2;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(180, 341);
            btn_Them.Margin = new Padding(2, 2, 2, 2);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(79, 26);
            btn_Them.TabIndex = 4;
            btn_Them.Text = "Thêm ";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(286, 341);
            btn_Sua.Margin = new Padding(2, 2, 2, 2);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(79, 26);
            btn_Sua.TabIndex = 5;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(386, 341);
            btn_Xoa.Margin = new Padding(2, 2, 2, 2);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(79, 26);
            btn_Xoa.TabIndex = 6;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // Ql_TaiKhoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 378);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Sua);
            Controls.Add(btn_Them);
            Controls.Add(txt_TimMaNV);
            Controls.Add(btn_TimMaNV);
            Controls.Add(dtgv_ThongTinNV);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Ql_TaiKhoan";
            Text = "TaiKhoan";
            ((System.ComponentModel.ISupportInitialize)dtgv_ThongTinNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_ThongTinNV;
        private Button btn_TimMaNV;
        private TextBox txt_TimMaNV;
        private Button btn_Them;
        private Button btn_Sua;
        private Button btn_Xoa;
    }
}