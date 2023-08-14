using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            return ProductDAO.Instance.GetProducts();
        }
        public Product GetProductById(int productID)
        {
            return ProductDAO.Instance.GetProductByID(productID);
        }

        // Search by id, name, price, unit in stock
        public List<Product> SearchProduct(int productID, string? productName, decimal unitPrice, int unitInstock)
        {
            return ProductDAO.Instance.SearchProduct(productID, productName, unitPrice, unitInstock);
        }


        public void UpdateQuantity(ShoppingCart cart)
        {
            ProductDAO.Instance.UpdateQuantity(cart);
        }

        public void CreateProduct(Product product)
        {
            ProductDAO.Instance.CreateProduct(product);
        }

        public void UpdateProduct(Product product)
        {
            ProductDAO.Instance.UpdateProduct(product);
        }

        public void DeleteProduct(int productID)
        {
            ProductDAO.Instance.DeleteProduct(productID);
        }

        public int GetMaxProductID()
        {
            return ProductDAO.Instance.GetMaxProductID();

        }
    }
}
