﻿using System;
namespace Discount.API.Enitities
{
        public class Coupon
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public int Amount { get; set; }
        }
    
}
