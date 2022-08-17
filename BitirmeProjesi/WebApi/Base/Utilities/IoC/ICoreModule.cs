using Microsoft.Extensions.DependencyInjection;

namespace Base
{
    public interface ICoreModule
    {
        void Load(IServiceCollection serviceCollection);
    }
}
