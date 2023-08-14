using BusinessObject;

namespace DataAccess
{
    public class OrderDAO
    {
        private static readonly object _locker = new object();
        private static OrderDAO _instance = null;
        FStoreContext context = new FStoreContext();

        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (_locker)
                {
                    if (_instance == null)
                    {
                        _instance = new OrderDAO();
                    }
                    return _instance;
                }
            }
        }

        private Order GetLast()
        {
            return context.Orders.OrderBy(order => order.OrderId).Last();
        }

        public void SaveOrder(ShoppingCart cart, int memberID)
        {
            List<CartItem> cartItems = cart.GetCart();
            decimal orderTotal = 0;
            if (cartItems != null && cartItems.Count() != 0)
            {
                foreach (var item in cartItems)
                {
                    var OrderDetail = new OrderDetail
                    {
                        OrderId = GetLast().OrderId + 1,
                        ProductId = item.ProductID,
                        Quantity = item.Quantity,
                        UnitPrice = context.Products.Single(c => c.ProductId == item.ProductID).UnitPrice,
                        Discount = item.Discount
                    };
                    orderTotal = item.Quantity * OrderDetail.UnitPrice;
                    context.OrderDetails.Add(OrderDetail);
                }

                var order = new Order
                {
                    OrderId = GetLast().OrderId + 1,
                    MemberId = memberID,
                    OrderDate = DateTime.Now,
                    RequiredDate = DateTime.Now,
                };

                context.Orders.Add(order);
                context.SaveChanges();

            }
            else
            {
                throw new Exception("Cart is empty");
            }


        }

        public Order GetOrderByOrderID(int orderID)
        {
            return context.Orders.Single(c => c.OrderId == orderID);
        }

        public List<Order> GetOrdersByMemberID(int memberID)
        {
            return context.Orders.Where(c => c.MemberId == memberID).ToList();
        }

        public List<Order> GetOrders()
        {
            return context.Orders.ToList();
        }

        public List<Order> GetOrdersFromTo(DateTime startDate, DateTime endDate)
        {
            var list = context.Orders.Where(c => c.OrderDate >= startDate && c.OrderDate <= endDate).ToList();
            return list.OrderByDescending(c => c.OrderDate).ToList();
        }

        public decimal GetStatisticsSale(DateTime startDate, DateTime endDate)
        {

            if (startDate < endDate)
            {
                throw new Exception("EndDate must be before StartDate");
            }
            else
            {
                var list = context.Orders.Where(c => c.OrderDate >= startDate && c.OrderDate <= endDate).ToList();
                return (from order in list select order.Freight).Sum() ?? decimal.Zero;

            }
        }

        public void UpdateOrder(DateTime requiredDate, DateTime shipDate, decimal freight, int orderID)
        {
            var order = context.Orders.FirstOrDefault(c => c.OrderId == orderID);
            if (order != null)
            {
                if (shipDate != null)
                {
                    order.ShipppedDate = shipDate;
                }
                if (requiredDate != null)
                {
                    order.RequiredDate = requiredDate;
                }
                if (freight != null)
                {
                    order.Freight = freight;
                }
                context.SaveChanges();

            }
            else
            {
                throw new Exception("Order does not exist");
            }
        }
    }
}
