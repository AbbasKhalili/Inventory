using System.Threading.Tasks;

namespace Framework.Application
{
    public interface ICommandHandler<in T> : ICommandHandler
    {
        Task Handle(T command);
    }
    public interface ICommandHandler
    {
    }
}
