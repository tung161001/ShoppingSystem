using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Order GetOrderByID(int orderID)
        {
            return OrderDAO.Instance.GetOrderByOrderID(orderID);
        }

        public List<Order> GetOrders()
        {
            return OrderDAO.Instance.GetOrders();
        }

        public List<Order> GetOrders(DateTime startDate, DateTime endDate)
        {
            return OrderDAO.Instance.GetOrdersFromTo(startDate, endDate);
        }

        public List<Order> GetOrdersByMemberID(int memberID)
        {
            return OrderDAO.Instance.GetOrdersByMemberID(memberID);
        }

        public void SaveOrder(ShoppingCart cart, int memberID)
        {
            OrderDAO.Instance.SaveOrder(cart, memberID);
        }

        public void UpdateOrder(DateTime requiredDate, DateTime shipDate, decimal freight, int orderID)
        {
            OrderDAO.Instance.UpdateOrder(requiredDate, shipDate, freight, orderID);
        }

    }
}
