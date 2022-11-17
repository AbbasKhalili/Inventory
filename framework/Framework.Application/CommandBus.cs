using Framework.Core;
using System;
using System.Threading.Tasks;

namespace Framework.Application
{
    public class CommandBus : ICommandBus
    {
        private readonly IServiceLocator _locator;

        public CommandBus(IServiceLocator locator)
        {
            _locator = locator;
        }

        public async Task Dispatch<T>(T command)
        {
            var execute = _locator.GetInstance<ICommandHandler<T>>();
            await execute.Handle(command);
        }
    }
}
