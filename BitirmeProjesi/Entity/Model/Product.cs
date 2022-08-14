﻿namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public bool IsOfferable { get; set; }
        public bool IsSold { get; set; }
    }
}