using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RapPhimFlix.Controllers
{
    public class Product
    {
        private string id;

        private string name;

        private decimal price;

        private string type;

        private string imgPath;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
        public string ImgPath { get => imgPath; set => imgPath = value; }
        public string Type { get => type; set => type = value; }

        public Product() { }

        public Product(string id, string name, decimal price, string? imgPath = null)
        {
            this.Id = id;
            this.name = name;
            this.price = price;
            this.imgPath = imgPath;
        }
        public Product(DataRow row) 
        {
            this.id = row["MaSanPham"].ToString();
            this.name = row["TenSanPham"].ToString();
            this.type = row["LoaiSanPham"].ToString();
            this.price = (decimal)row["Gia"];
            this.imgPath = row["Anh"].ToString();
        }
    }
}
