﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebGoatCore.Models
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

        public decimal ExtendedPrice => UnitPrice * Convert.ToDecimal(1 - Discount) * Quantity;
    }
}
