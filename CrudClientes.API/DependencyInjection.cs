using CrudClientes.Interface;
using CrudClientes.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CrudClientes.API
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection serviceProvider)
        {
            RepositorDependence(serviceProvider);
        }

        private static void RepositorDependence(IServiceCollection serviceProvider)
        {
            //serviceProvider.AddScoped<Interface, ClasseConcreta>();
            serviceProvider.AddScoped<IClienteRepository, ClienteRepository>();
            serviceProvider.AddScoped<ICidadeRepository, CidadeRepository>();
            serviceProvider.AddScoped<IEstadoRepository, EstadoRepository>();
        }
    }
}
