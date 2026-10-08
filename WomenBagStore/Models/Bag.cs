using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WomenBagStore.Models
{
    // Bag.cs
    namespace YourProjectNamespace.Models
    {
        public class Bag
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public decimal Price { get; set; }
        }
    }
}