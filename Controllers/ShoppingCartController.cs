using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Extensions;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

namespace OnlineBookStore.Controllers
{
    public class ShoppingCartController : Controller
    {
        private IBookItemServices bookItemServices;
        public ShoppingCartController(IBookItemServices bookItemServices)
        {
            this.bookItemServices = bookItemServices;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShoppingCartList()
        {
            ShoppingCart shoppingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("shoppingCart");

            if (shoppingCart == null)
                shoppingCart = new ShoppingCart() { cartItemList = new List<CartItem>() { } };

            return View(shoppingCart);
        }


  

        public IActionResult AddToCart(int id)
        {
            ShoppingCart shoppingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("shoppingCart");

            if (shoppingCart == null)
                shoppingCart = new ShoppingCart() { cartItemList = new List<CartItem>() };

            BookItem bookItem = bookItemServices.GetBookItemById(id);

            var CartItemToAdd = shoppingCart.cartItemList.Where(i => i.bookItemId == bookItem.bookItemId).FirstOrDefault();

            if (CartItemToAdd == null)
            {

                CartItemToAdd = new CartItem()
                {
                    bookItemId = bookItem.bookItemId,
                    bookItem = bookItem,
                    itemQuantity = 1,
                    totalItemPrice = bookItem.purchasePrice
                };
                shoppingCart.cartItemList.Add(CartItemToAdd);
            }
            else
            {
                CartItemToAdd.itemQuantity = CartItemToAdd.itemQuantity + 1;
                CartItemToAdd.totalItemPrice = CartItemToAdd.itemQuantity * bookItem.purchasePrice;

            }

            shoppingCart.totalCartQuantity = shoppingCart.cartItemList.Sum(q => q.itemQuantity);
            shoppingCart.totalCartPrice = shoppingCart.cartItemList.Sum(p => p.totalItemPrice);

            HttpContext.Session.SetObjectToJson("shoppingCart", shoppingCart);
            return RedirectToAction("ShoppingCartList");

        }

        public IActionResult RemoveFromCart(int id)
        {
            ShoppingCart shoppingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("shoppingCart");


            BookItem bookItem = bookItemServices.GetBookItemById(id);

            var CartItemToRemove = shoppingCart.cartItemList.Where(i => i.bookItemId == bookItem.bookItemId).FirstOrDefault();
             shoppingCart.cartItemList.Remove(CartItemToRemove);

            shoppingCart.totalCartQuantity = shoppingCart.cartItemList.Sum(q => q.itemQuantity);
            shoppingCart.totalCartPrice = shoppingCart.cartItemList.Sum(p => p.totalItemPrice);


            HttpContext.Session.SetObjectToJson("shoppingCart", shoppingCart);
            return RedirectToAction("ShoppingCartList");

        }
    }
}
