using Framework.Core.Exceptions;

namespace Inventory.Application.Exceptions
{
    public class ProductNotFoundException : BusinessException
    {
        public ProductNotFoundException() : base(102)
        {
        }
    }
}
