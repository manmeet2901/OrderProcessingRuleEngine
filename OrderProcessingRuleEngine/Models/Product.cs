﻿using System.Collections.Generic;

namespace OrderProcessingRuleEngine.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int ProductName { get; set; }
        public ProductType Type { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public string UOM { get; set; }
        //We're in the endgame now
        public List<string> ProductRules { get; set; }
    }

    public enum ProductType
    {
        None = 0,
        Goods = 1,
        Service = 2
    }
}