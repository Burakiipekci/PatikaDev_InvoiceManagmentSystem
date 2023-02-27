using Microsoft.Extensions.DependencyInjection;

namespace InvoiceManagmentSystem.Core.Utilities.IoC
{
    public interface ICoreModule
    {
        void Load(IServiceCollection services);
    }
}