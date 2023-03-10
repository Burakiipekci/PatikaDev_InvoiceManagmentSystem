
using InvoiceManagmentSystem.Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;

namespace InvoiceManagmentSystem.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyResolvers(this IServiceCollection service, params ICoreModule[] modules)
        {
            foreach (var module in modules)
                module.Load(service);

            return ServiceTool.Create(service);
        }
    }
}
