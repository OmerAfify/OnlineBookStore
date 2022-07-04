using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineBookStore.Models;

namespace OnlineBookStore.Interfaces
{
    public interface IOrderServices
    {
        public void addOrder(Order order);
        public void addOrderDetails(OrderDetails orderDetails);
        public void addOrderedItem(OrderedItem orderItem);
    }
}
