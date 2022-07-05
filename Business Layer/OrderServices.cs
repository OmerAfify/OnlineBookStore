using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

namespace OnlineBookStore.Business_Layer
{           
      public class OrderServices: IOrderServices
      {
           
        private OnlineBookStoreDbContext _context;

        public OrderServices(OnlineBookStoreDbContext context) {
            _context = context;
        }




        public void addOrder(Order order)
        {
            _context.Tb_Orders.Add(order);
            _context.SaveChanges();

        }


        public void addOrderDetails(OrderDetails orderDetails)
        {
            _context.Tb_OrderDetails.Add(orderDetails);
            _context.SaveChanges();

        }

        public void addOrderedItem(OrderedItem orderedItem)
        {
              _context.Tb_OrderedItems.Add(orderedItem);
                _context.SaveChanges();
        }




        public List<Order> viewUsersOrders(string userId)
        {
          var orders = _context.Tb_Orders.Where(o => o.userId == userId)
             .Include(od => od.orderDetails)
                .ThenInclude(oi => oi.orderedItems)
                    .ThenInclude(bi => bi.bookItem)
                        .ToList();

            return orders;
        }


    }
}
