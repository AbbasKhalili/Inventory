using Framework.Core;
using System.Threading.Tasks;

namespace Inventory.Domain.DepartureReceipts.DomainServices
{
    public interface IInquiryExistingProductDomainService : IDomainService
    {
        Task Inqiry(long productId, int quantity);
    }
}
