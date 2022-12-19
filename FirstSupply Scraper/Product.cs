using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSupply_Scraper
{
    internal class Product
    {
        public string cat1 { get; set; }
        public string cat2 { get; set; }
        public string cat3 { get; set; }
        public string cat4 { get; set; }
        public string cat5 { get; set; }
        public string prodNum { get; set; }
        public string catTree { get; set; }
        public string model { get; set; }

        public Product(string productNumber, string model)
        {
            this.catTree = "Thos Somerville";
            this.prodNum = productNumber;
            this.model = model;
        }
    }
}
