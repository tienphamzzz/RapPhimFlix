namespace RapPhimFlix
{
    partial class uclProduct
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
            pbProductPicture = new PictureBox();
            lblProductName = new Label();
            lblProductPrice = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbProductPicture).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbProductPicture
            // 
            pbProductPicture.Location = new Point(3, 3);
            pbProductPicture.Name = "pbProductPicture";
            pbProductPicture.Size = new Size(186, 181);
            pbProductPicture.TabIndex = 0;
            pbProductPicture.TabStop = false;
            pbProductPicture.DoubleClick += pbProductPicture_DoubleClick;
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top;
            lblProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(1, 185);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(184, 25);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Khoai tay chien";
            lblProductName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblProductPrice
            // 
            lblProductPrice.Anchor = AnchorStyles.Top;
            lblProductPrice.Location = new Point(5, 224);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(182, 20);
            lblProductPrice.TabIndex = 2;
            lblProductPrice.Text = "label2";
            lblProductPrice.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblProductName);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 264);
            panel1.TabIndex = 3;
            panel1.Click += panel1_Click;
            // 
            // uclProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblProductPrice);
            Controls.Add(pbProductPicture);
            Controls.Add(panel1);
            Name = "uclProduct";
            Size = new Size(192, 264);
            ((System.ComponentModel.ISupportInitialize)pbProductPicture).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbProductPicture;
        private Label lblProductName;
        private Label lblProductPrice;
        private Panel panel1;
    }
}
