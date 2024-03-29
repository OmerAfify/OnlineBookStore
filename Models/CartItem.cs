﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBookStore.Models
{
    public class CartItem
    {
        public int bookItemId { get; set; }
        public virtual BookItem bookItem { get; set; }
        public int totalItemQuantity { get; set; }
        public decimal  totalItemPrice { get; set; }
    }
}
