using RapPhimFlix.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapPhimFlix
{
    public partial class uclProduct : UserControl
    {
        public uclProduct()
        {
            InitializeComponent();
        }

        public uclProduct(Product product)
        {
            InitializeComponent();

            //setProductImg(product.ImgPath);
            setProductName(product.Name);
            setProductPrice((float)product.Price);
            ExportFile.loadImage(pbProductPicture, "Resources\\images\\sanphams", product.Name);
        }

        public void setProductImg(string? imgPath = null)
        {
            pbProductPicture.Image = Image.FromFile(imgPath);
        }

        public void setProductName(string name)
        {
            lblProductName.Text = name;
        }
        public string getProductName()
        {
            return lblProductName.Text;
        }

        public void setProductPrice(float price)
        {
            lblProductPrice.Text = price.ToString();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void pbProductPicture_DoubleClick(object sender, EventArgs e)
        {
            ProductClick?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler ProductClick;
    }
}
