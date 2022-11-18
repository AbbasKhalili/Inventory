using Framework.Core.Exceptions;

namespace Inventory.Domain.Exceptions
{
    public class ProductUnavailableException : BusinessException
    {
        public ProductUnavailableException() : base(103)
        {
        }
    }
}
