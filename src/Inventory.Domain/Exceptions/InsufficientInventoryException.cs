using Framework.Core.Exceptions;

namespace Inventory.Domain.Exceptions
{
    public class InsufficientInventoryException : BusinessException
    {
        public InsufficientInventoryException() : base(104)
        {
        }
    }
}
