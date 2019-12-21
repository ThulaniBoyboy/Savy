using System;
using savy.domain.Entities.BaseModels;

namespace savy.domain.Entities.Catalog
{
    public class Product : BaseEntity
    {
        public string name { get; set; }    
        public double Price { get; set; }
        public string Description { get; set; }
    }
}