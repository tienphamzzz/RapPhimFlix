namespace RapPhimFlix.Forms.UserControls
{
    partial class ucPhim
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grb_HienThi = new GroupBox();
            btn_Them = new Button();
            ptb_HienThi = new PictureBox();
            grb_HienThi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptb_HienThi).BeginInit();
            SuspendLayout();
            // 
            // grb_HienThi
            // 
            grb_HienThi.Controls.Add(btn_Them);
            grb_HienThi.Controls.Add(ptb_HienThi);
            grb_HienThi.Location = new Point(0, 0);
            grb_HienThi.Name = "grb_HienThi";
            grb_HienThi.Size = new Size(140, 210);
            grb_HienThi.TabIndex = 1;
            grb_HienThi.TabStop = false;
            grb_HienThi.Text = "ten-phim";
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(30, 181);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(75, 23);
            btn_Them.TabIndex = 1;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // ptb_HienThi
            // 
            ptb_HienThi.Location = new Point(6, 14);
            ptb_HienThi.Name = "ptb_HienThi";
            ptb_HienThi.Size = new Size(128, 161);
            ptb_HienThi.TabIndex = 0;
            ptb_HienThi.TabStop = false;
            // 
            // ucPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grb_HienThi);
            Name = "ucPhim";
            Size = new Size(140, 210);
            grb_HienThi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptb_HienThi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_HienThi;
        private Button btn_Them;
        private PictureBox ptb_HienThi;
    }
}
