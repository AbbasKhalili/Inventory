using System.Threading.Tasks;

namespace Framework.Core
{
    public interface IUnitOfWork
    {
        Task Begin();
        Task Commit();
        Task Rollback();
    }
}
