using BusinessObject;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        private static readonly object locker = new object();
        private FStoreContext context = new FStoreContext();
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        private OrderDetailDAO() { }

        public List<OrderDetail> GetOrderDetailsByOrderID(int orderID)
        {
            return context.OrderDetails.Where(orderDetail => orderDetail.OrderId == orderID).ToList();
        }

        public decimal GetTotal(int orderID)
        {
            decimal total = (from item in GetOrderDetailsByOrderID(orderID)
                             select item.Quantity * context.Products.Single(c => c.ProductId == item.ProductId).UnitPrice
                             ).Sum();
            return total;
        }
    }
}
