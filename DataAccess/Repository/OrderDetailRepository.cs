using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<OrderDetail> getOrderDetailsByOrderID(int orderID) => OrderDetailDAO.Instance.GetOrderDetailsByOrderID(orderID);
        public decimal GetTotal(int orderID)
        {
            return OrderDetailDAO.Instance.GetTotal(orderID);
        }
    }
}
