namespace RapPhimFlix
{
    partial class Main
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
            btn_vo = new Button();
            SuspendLayout();
            // 
            // btn_vo
            // 
            btn_vo.Location = new Point(188, 111);
            btn_vo.Name = "btn_vo";
            btn_vo.Size = new Size(192, 59);
            btn_vo.TabIndex = 0;
            btn_vo.Text = "vô";
            btn_vo.UseVisualStyleBackColor = true;
            btn_vo.Click += btn_vo_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_vo);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_vo;
    }
}