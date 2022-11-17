using Framework.Core.Exceptions;

namespace Inventory.Application.Exceptions
{
    public class CategoryNotFoundException : BusinessException
    {
        public CategoryNotFoundException() : base(101)
        {
        }
    }
}
