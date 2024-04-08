using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.BL;

namespace RMS.DL
{
    public interface IProductDL
    {
        void SaveProduct(Product P);
        void SaveVariant(ProductVariant PV, int productID);
        List<Product> GetProducts();
        bool ProductExists(string productName);
        void DeleteProduct(int productID);
        int GetProductID(string productName);
        bool HasVariants(int productID);
        void UpdateProduct(Product P);  
    }
}
