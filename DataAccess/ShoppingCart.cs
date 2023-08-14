using BusinessObject;

namespace DataAccess
{
    public class ShoppingCart
    {
        FStoreContext context = new FStoreContext();
        public List<CartItem> Cart;
        public ShoppingCart()
        {
            Cart = new List<CartItem>();
        }
        public List<CartItem> GetCart()
        {
            return Cart;
        }

        public void AddToCart(Product product, int quantity)
        {
            var cartItem = Cart.SingleOrDefault(c => c.ProductID == product.ProductId);
            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    ProductID = product.ProductId,
                    ProductName = product.ProductName,
                    Quantity = quantity,
                };
                Cart.Add(cartItem);

            }
            else
            {
                cartItem.Quantity += quantity;
            }
        }

        public void UpdateCart(Product product, int quantity)
        {
            var cartItem = Cart.FirstOrDefault(c => c.ProductID == product.ProductId);
            if (cartItem != null)
            {
                cartItem.Quantity = quantity;
            }
            else
            {
                throw new Exception("Cart item is not existed");
            }
        }

        public void RemoveToCart(Product product)
        {
            var cartItem = Cart.SingleOrDefault(c => c.ProductID == product.ProductId);

            if (cartItem != null)
            {

                Cart.Remove(cartItem);
            }
            else
            {
                throw new Exception("Cart item is not existed");
            }
        }

        public decimal GetTotal()
        {
            decimal total = (from cartItem in Cart
                             select cartItem.Quantity *
                             context.Products.Single(c => c.ProductId == cartItem.ProductID).UnitPrice
                    ).Sum();

            return total;
        }

        public void EmptyCart()
        {
            Cart.Clear();
        }
    }
}
