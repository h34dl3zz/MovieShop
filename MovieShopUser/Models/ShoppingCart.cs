﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieShopUser.Models
{
    public class ShoppingCart
    {
        
        public List<OrderLine> OrderLines { get; set; }
        public ShoppingCart(List<OrderLine> lines)
        {
            OrderLines = lines;
        }
        public DateTime Created { get; set; }
        public void AddOrderLine(OrderLine line)
        {
            OrderLines.Add(line);
        }
        public void RemoveOrderLine(OrderLine line)
        {
            OrderLines.Remove(line);
        }
    }
}