using Framework.Domain;
using Inventory.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory.Domain.Categories
{
    public class Category : EntityBase<long>, IAggregateRoot
    {
        public string Name { get; private set; }


        private HashSet<Product> _products = new HashSet<Product>();
        public IEnumerable<Product> Products => _products?.ToList();

        protected Category() { }
        public Category(string name)
        {
            Name = name;
            CreatedAt = DateTime.Now;
            LastModified = DateTime.Now;
            SurrogateKey = Guid.NewGuid();
        }
    }
}
