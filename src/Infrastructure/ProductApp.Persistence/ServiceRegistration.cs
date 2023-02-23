using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProductApp.Application.Interfaces.Repository;
using ProductApp.Persistence.Context;
using ProductApp.Persistence.Repositories;

namespace ProductApp.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddDbContext<ApplicationDbContext>(options =>options.UseInMemoryDatabase("memoryDb"));
            servicesCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
