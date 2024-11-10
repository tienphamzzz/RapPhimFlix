namespace RapPhimFlix.Forms
{
    partial class ChonSanPham
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            gbOrder = new GroupBox();
            lblProductName = new Label();
            txtProductName = new TextBox();
            lblTotal = new Label();
            btnConfirm = new Button();
            nudProductQuantity = new NumericUpDown();
            panel1 = new Panel();
            btnAddProduct = new Button();
            panel2 = new Panel();
            lvSelectedProducts = new ListView();
            gbProductsList = new GroupBox();
            flpProducts = new FlowLayoutPanel();
            gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProductQuantity).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            gbProductsList.SuspendLayout();
            SuspendLayout();
            // 
            // gbOrder
            // 
            gbOrder.Controls.Add(lvSelectedProducts);
            gbOrder.Controls.Add(panel2);
            gbOrder.Controls.Add(panel1);
            gbOrder.Location = new Point(585, 20);
            gbOrder.Name = "gbOrder";
            gbOrder.Size = new Size(407, 545);
            gbOrder.TabIndex = 1;
            gbOrder.TabStop = false;
            gbOrder.Text = "Thông tin đặt hàng";
            gbOrder.Enter += groupBoxOrder_Enter;
            // 
            // lblProductName
            // 
            lblProductName.Location = new Point(14, 10);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(100, 23);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(120, 7);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(180, 27);
            txtProductName.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(18, 10);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(261, 34);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(118, 40);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "Xác nhận";
            // 
            // nudProductQuantity
            // 
            nudProductQuantity.Location = new Point(330, 6);
            nudProductQuantity.Name = "nudProductQuantity";
            nudProductQuantity.Size = new Size(49, 27);
            nudProductQuantity.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddProduct);
            panel1.Controls.Add(lblProductName);
            panel1.Controls.Add(nudProductQuantity);
            panel1.Controls.Add(txtProductName);
            panel1.Location = new Point(6, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 108);
            panel1.TabIndex = 19;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(261, 50);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(118, 40);
            btnAddProduct.TabIndex = 20;
            btnAddProduct.Text = "Thêm";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnConfirm);
            panel2.Location = new Point(6, 451);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 88);
            panel2.TabIndex = 20;
            // 
            // lvSelectedProducts
            // 
            lvSelectedProducts.Location = new Point(6, 139);
            lvSelectedProducts.Name = "lvSelectedProducts";
            lvSelectedProducts.Size = new Size(395, 306);
            lvSelectedProducts.TabIndex = 21;
            lvSelectedProducts.UseCompatibleStateImageBehavior = false;
            // 
            // gbProductsList
            // 
            gbProductsList.Controls.Add(flpProducts);
            gbProductsList.Location = new Point(12, 20);
            gbProductsList.Name = "gbProductsList";
            gbProductsList.Size = new Size(567, 545);
            gbProductsList.TabIndex = 2;
            gbProductsList.TabStop = false;
            gbProductsList.Text = "Chọn sản phẩm";
            // 
            // flpProducts
            // 
            flpProducts.Location = new Point(6, 26);
            flpProducts.Name = "flpProducts";
            flpProducts.Size = new Size(555, 513);
            flpProducts.TabIndex = 0;
            // 
            // ChonSanPham
            // 
            Controls.Add(gbProductsList);
            Controls.Add(gbOrder);
            Name = "ChonSanPham";
            Size = new Size(1024, 586);
            gbOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudProductQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            gbProductsList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnConfirm;
        private NumericUpDown nudProductQuantity;
        private Panel panel1;
        private Panel panel2;
        private Button btnAddProduct;
        private ListView lvSelectedProducts;
        private GroupBox gbProductsList;
        private FlowLayoutPanel flpProducts;
    }
}
