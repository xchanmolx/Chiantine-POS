using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSaleViewerForm
{
    public class Product
    {
        public int Id { get; set; }

        public string SKU { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public decimal Total { get { return ((Math.Round(Price, 2) * Quantity) - Discount); } }

        public decimal Discount { get; set; }

        public DateTime Date { get; set; }        
    }
}
