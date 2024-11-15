namespace RapPhimFlix.Forms
{
    partial class frmListPhim
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
            flp_main = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flp_main
            // 
            flp_main.AutoScroll = true;
            flp_main.Dock = DockStyle.Fill;
            flp_main.Location = new Point(0, 0);
            flp_main.Name = "flp_main";
            flp_main.Size = new Size(896, 474);
            flp_main.TabIndex = 0;
            // 
            // frmListPhim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 474);
            Controls.Add(flp_main);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmListPhim";
            Text = "listPhim";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flp_main;
    }
}