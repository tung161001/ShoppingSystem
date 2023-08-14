using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        void SaveOrder(ShoppingCart cart, int memberID);

        List<Order> GetOrdersByMemberID(int memberID);
        List<Order> GetOrders();
        List<Order> GetOrders(DateTime startDate, DateTime endDate);
        void UpdateOrder(DateTime requiredDate, DateTime shipDate, decimal freight, int orderID);

        Order GetOrderByID(int orderID);
    }
}
