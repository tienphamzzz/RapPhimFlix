namespace RapPhimFlix.Forms
{
    partial class frmListPhim2
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
            flp_HienThi = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flp_HienThi
            // 
            flp_HienThi.Dock = DockStyle.Fill;
            flp_HienThi.Location = new Point(0, 0);
            flp_HienThi.Name = "flp_HienThi";
            flp_HienThi.Size = new Size(912, 513);
            flp_HienThi.TabIndex = 0;
            // 
            // frmListPhim2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flp_HienThi);
            Name = "frmListPhim2";
            Size = new Size(912, 513);
            Load += frmListPhim2_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_HienThi;
    }
}
