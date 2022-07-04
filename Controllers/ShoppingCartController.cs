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
        private OnlineBookStoreDbContext _context;
        public ShoppingCartController(IBookItemServices bookItemServices, OnlineBookStoreDbContext context)
        {
            this.bookItemServices = bookItemServices;
            _context = context;
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
                    totalItemQuantity = 1,
                    totalItemPrice = bookItem.purchasePrice
                };

                shoppingCart.cartItemList.Add(CartItemToAdd);
            }
            else
            {
                CartItemToAdd.totalItemQuantity = CartItemToAdd.totalItemQuantity + 1;
                CartItemToAdd.totalItemPrice = CartItemToAdd.totalItemQuantity * bookItem.purchasePrice;
            }

            shoppingCart.totalShoppingCartQuantity = shoppingCart.cartItemList.Sum(q => q.totalItemQuantity);
            shoppingCart.totalShoppingCartPrice = shoppingCart.cartItemList.Sum(p => p.totalItemPrice);

            HttpContext.Session.SetObjectToJson("shoppingCart", shoppingCart);
            return RedirectToAction("ShoppingCartList");

        }

        public IActionResult RemoveFromCart(int id)
        {
            ShoppingCart shoppingCart = HttpContext.Session.GetObjectFromJson<ShoppingCart>("shoppingCart");

            BookItem bookItem = bookItemServices.GetBookItemById(id);

            var CartItemToRemove = shoppingCart.cartItemList.Where(i => i.bookItemId == bookItem.bookItemId).FirstOrDefault();
             shoppingCart.cartItemList.Remove(CartItemToRemove);

            shoppingCart.totalShoppingCartQuantity = shoppingCart.cartItemList.Sum(q => q.totalItemQuantity);
            shoppingCart.totalShoppingCartPrice = shoppingCart.cartItemList.Sum(p => p.totalItemPrice);


            HttpContext.Session.SetObjectToJson("shoppingCart", shoppingCart);
            return RedirectToAction("ShoppingCartList");

        }


      
        public IActionResult SaveItemsToCart()
        {
            return Redirect("~/");
        }




    }
}
