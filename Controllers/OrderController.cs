using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Extensions;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;
using OnlineBookStore.ViewModels;

namespace OnlineBookStore.Controllers
{

    [Authorize(Roles="Customer")]
    public class OrderController : Controller
    {

        private IOrderServices _orderService;
        public OrderController(IOrderServices orderService)
        {
            _orderService = orderService;

        }


        public IActionResult Checkout()
        {

            ShoppingCart shoppingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("shoppingCart");

            if (shoppingCart == null)
                shoppingCart = new ShoppingCart() { cartItemList = new List<CartItem>() { } };

            OrderDetailsAndShoppingCartViewModel vm = new OrderDetailsAndShoppingCartViewModel()
            {
                orderDetails = new OrderDetails() { },
                shoppingCart = shoppingCart
            };

            return View(vm);
        }


        [HttpPost]
        public IActionResult PLaceOrder(OrderDetails orderDetails)
        {
            if (ModelState.IsValid) { 
            var shoppingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("shoppingCart");

                if (shoppingCart == null)
                    shoppingCart = new ShoppingCart() { cartItemList = new List<CartItem>() { } };

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Order order = new Order()
            {
                userId = userId,
                orderStatusId = 1,
            };
            _orderService.addOrder(order);


            orderDetails.orderId = order.orderId;
            orderDetails.totalPrice = shoppingCart.totalShoppingCartPrice;
            orderDetails.totalQuantity = shoppingCart.totalShoppingCartQuantity;
            _orderService.addOrderDetails(orderDetails);

            foreach(var item in shoppingCart.cartItemList) {
                OrderedItem orderedItem = new OrderedItem()
                {
                    bookItemId = item.bookItemId,
                    orderDetailsId = orderDetails.orderDetailsId,
                    totalItemPrice = item.totalItemPrice,
                    totalItemQuantity = item.totalItemQuantity

                }; _orderService.addOrderedItem(orderedItem);
            }          
            HttpContext.Session.Remove("shoppingCart");
            return RedirectToAction("OrderSuccess");

            }
            else
            {
                OrderDetailsAndShoppingCartViewModel vm = new OrderDetailsAndShoppingCartViewModel()
                {
                    orderDetails =orderDetails,
                    shoppingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("shoppingCart")
                };
                return View("Checkout", vm);
            }
        }



       public IActionResult OrderSuccess()
        {
            return View();
        }



         public IActionResult TrackOrders()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var orders = _orderService.viewUsersOrders(userId);

            if (orders == null)
                orders = new List<Order>() { };

            return View(orders);
        }



    }
}
