namespace RapPhimFlix.Forms.DangNhap
{
    partial class FormDangNhap
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
            panel1 = new Panel();
            label1 = new Label();
            ptb_DangNhap_TaiKhoan = new PictureBox();
            txt_DangNhap_TaiKhoan = new TextBox();
            txt_DangNhap_MatKhau = new TextBox();
            ptb_DangNhap_MatKhau = new PictureBox();
            btn_DangNhap_DangNhap = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_DangNhap_TaiKhoan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptb_DangNhap_MatKhau).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_DangNhap_DangNhap);
            panel1.Controls.Add(txt_DangNhap_MatKhau);
            panel1.Controls.Add(ptb_DangNhap_MatKhau);
            panel1.Controls.Add(txt_DangNhap_TaiKhoan);
            panel1.Controls.Add(ptb_DangNhap_TaiKhoan);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 423);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(218, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 36);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // ptb_DangNhap_TaiKhoan
            // 
            ptb_DangNhap_TaiKhoan.Location = new Point(74, 146);
            ptb_DangNhap_TaiKhoan.Margin = new Padding(4, 4, 4, 4);
            ptb_DangNhap_TaiKhoan.Name = "ptb_DangNhap_TaiKhoan";
            ptb_DangNhap_TaiKhoan.Size = new Size(43, 42);
            ptb_DangNhap_TaiKhoan.TabIndex = 1;
            ptb_DangNhap_TaiKhoan.TabStop = false;
            // 
            // txt_DangNhap_TaiKhoan
            // 
            txt_DangNhap_TaiKhoan.Location = new Point(150, 146);
            txt_DangNhap_TaiKhoan.Margin = new Padding(4, 4, 4, 4);
            txt_DangNhap_TaiKhoan.Multiline = true;
            txt_DangNhap_TaiKhoan.Name = "txt_DangNhap_TaiKhoan";
            txt_DangNhap_TaiKhoan.Size = new Size(381, 40);
            txt_DangNhap_TaiKhoan.TabIndex = 2;
            // 
            // txt_DangNhap_MatKhau
            // 
            txt_DangNhap_MatKhau.Location = new Point(150, 203);
            txt_DangNhap_MatKhau.Margin = new Padding(4, 4, 4, 4);
            txt_DangNhap_MatKhau.Multiline = true;
            txt_DangNhap_MatKhau.Name = "txt_DangNhap_MatKhau";
            txt_DangNhap_MatKhau.Size = new Size(381, 40);
            txt_DangNhap_MatKhau.TabIndex = 4;
            // 
            // ptb_DangNhap_MatKhau
            // 
            ptb_DangNhap_MatKhau.Location = new Point(74, 203);
            ptb_DangNhap_MatKhau.Margin = new Padding(4, 4, 4, 4);
            ptb_DangNhap_MatKhau.Name = "ptb_DangNhap_MatKhau";
            ptb_DangNhap_MatKhau.Size = new Size(43, 42);
            ptb_DangNhap_MatKhau.TabIndex = 3;
            ptb_DangNhap_MatKhau.TabStop = false;
            // 
            // btn_DangNhap_DangNhap
            // 
            btn_DangNhap_DangNhap.Location = new Point(254, 287);
            btn_DangNhap_DangNhap.Margin = new Padding(4, 4, 4, 4);
            btn_DangNhap_DangNhap.Name = "btn_DangNhap_DangNhap";
            btn_DangNhap_DangNhap.Size = new Size(107, 32);
            btn_DangNhap_DangNhap.TabIndex = 5;
            btn_DangNhap_DangNhap.Text = "Đăng nhập";
            btn_DangNhap_DangNhap.UseVisualStyleBackColor = true;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 423);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormDangNhap";
            Text = "FormDangNhap";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_DangNhap_TaiKhoan).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptb_DangNhap_MatKhau).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_DangNhap_DangNhap;
        private TextBox txt_DangNhap_MatKhau;
        private PictureBox ptb_DangNhap_MatKhau;
        private TextBox txt_DangNhap_TaiKhoan;
        private PictureBox ptb_DangNhap_TaiKhoan;
        private Label label1;
    }
}