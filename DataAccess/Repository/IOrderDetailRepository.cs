using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<OrderDetail> getOrderDetailsByOrderID(int orderID);
        decimal GetTotal(int orderID);
    }
}
