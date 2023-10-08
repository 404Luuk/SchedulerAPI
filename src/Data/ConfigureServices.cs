using System.Reflection;
using Data.Data;
using Data.IRepository;
using Data.IServices;
using Data.Repository;
using Data.Services;

namespace Data;

public static class ConfigureServices
{
    public static async Task<IServiceCollection> AddDataServices(this IServiceCollection services)
    {
        
        using (var serviceScope = services.BuildServiceProvider().CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<DatabaseContext>();
            await context.Database.EnsureCreatedAsync();
        }
        
        
        // Add services to the container.
        services.AddScoped<IServiceManager, ServiceManager>();
        services.AddScoped<IRepositoryManager, RepositoryManager>();
        services.AddScoped<INoteRepository, NoteRepository>();
        services.AddScoped<INoteService, NoteService>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        return services;
    }
}