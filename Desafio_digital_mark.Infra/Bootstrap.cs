using Desafio_digital_mark.Application.App;
using Desafio_digital_mark.Application.Interface;
using Desafio_digital_mark.Application.Mapper;
using Desafio_digital_mark.Data;
using Desafio_digital_mark.Data.Repositorio;
using Desafio_digital_mark.Domain.Repositorio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Desafio_digital_mark.Infra;

public class Bootstrap
{
    public static void RegistroDeServicos(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
        services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
        services.AddScoped<IProjetoRepositorio, ProjetoRepositorio>();

        services.AddAutoMapper(typeof(AutoMapperConfig));

        services.AddScoped<IClienteAplicacao, ClienteAplicacao>();
        services.AddScoped<IProjetoAplicacao, ProjetoAplicacao>();

        services.AddDbContext<Contexto>(options => 
            options.UseSqlServer(configuration.GetConnectionString("Conexao")));
    }
}
