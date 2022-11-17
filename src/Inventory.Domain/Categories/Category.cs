using Framework.Domain;
using System;

namespace Inventory.Domain.Categories
{
    public class Category : EntityBase<CategoryId>, IAggregateRoot
    {
        public string Name { get; private set; }

        protected Category() { }
        public Category(string name)
        {
            Name = name;
            CreatedOn = DateTime.Now;
            LastModified = DateTime.Now;
        }
    }
}
