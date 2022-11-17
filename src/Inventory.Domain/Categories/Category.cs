using Framework.Domain;
using System;

namespace Inventory.Domain.Categories
{
    public class Category : EntityBase<CategoryId>, IAggregateRoot
    {
        public string Name { get; private set; }
        public Guid SurrogateKey { get; private set; }

        public Category(string name)
        {
            Name = name;
            SurrogateKey = Guid.NewGuid();
        }
    }
}
