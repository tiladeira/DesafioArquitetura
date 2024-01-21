using DesafioArquitetura.Domain.Interfaces.Repositories;
using DesafioArquitetura.Domain.Interfaces.Services;
using DesafioArquitetura.Domain.Services;
using DesafioArquitetura.Infra.Data.Context;
using DesafioArquitetura.Infra.Data.Repository;
using DesafioArquitetura.UnitOfWork;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioArquitetura.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUnitOfWorkRepository, UnitOfWorkRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteLancamentoRepository, ClienteLancamentoRepository>();
            services.AddScoped<ILancamentoRepository, LancamentoRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteLancamentoService, ClienteLancamentoService>();
            services.AddScoped<ILancamentoService, LancamentoService>();

            return services;
        }
    }
}
