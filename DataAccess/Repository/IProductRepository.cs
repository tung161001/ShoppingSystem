using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
        Product GetProductById(int productID);

        // Search by id, name, price, unit in stock
        List<Product> SearchProduct(int productID, string? productName, decimal unitPrice, int unitInstock);
        void UpdateQuantity(ShoppingCart cart);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productID);
        int GetMaxProductID();
    }
}
