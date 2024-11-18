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
            ((System.ComponentModel.ISupportInitialize)pbProductPicture).BeginInit();
            SuspendLayout();
            // 
            // pbProductPicture
            // 
            pbProductPicture.Location = new Point(0, 0);
            pbProductPicture.Name = "pbProductPicture";
            pbProductPicture.Size = new Size(169, 150);
            pbProductPicture.TabIndex = 0;
            pbProductPicture.TabStop = false;
            pbProductPicture.DoubleClick += pbProductPicture_DoubleClick;
            // 
            // lblProductName
            // 
            lblProductName.Anchor = AnchorStyles.Top;
            lblProductName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductName.Location = new Point(4, 153);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(159, 25);
            lblProductName.TabIndex = 1;
            lblProductName.Text = "Khoai tay chien";
            lblProductName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblProductPrice
            // 
            lblProductPrice.Anchor = AnchorStyles.Top;
            lblProductPrice.Location = new Point(5, 187);
            lblProductPrice.Name = "lblProductPrice";
            lblProductPrice.Size = new Size(159, 25);
            lblProductPrice.TabIndex = 2;
            lblProductPrice.Text = "label2";
            lblProductPrice.TextAlign = ContentAlignment.TopCenter;
            // 
            // uclProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblProductPrice);
            Controls.Add(pbProductPicture);
            Controls.Add(lblProductName);
            Name = "uclProduct";
            Size = new Size(170, 217);
            ((System.ComponentModel.ISupportInitialize)pbProductPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbProductPicture;
        private Label lblProductName;
        private Label lblProductPrice;
    }
}
