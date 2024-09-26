using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.IO; // Certifique-se de que este namespace está sendo usado

namespace PessoaService.Infrastructure
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            // Cria o builder de opções de DbContext
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Ajuste o caminho para o appsettings.json, supondo que ele esteja na pasta do projeto principal
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "..", "PessoaService.API")) // Ajuste para o caminho correto do seu projeto principal
                .AddJsonFile("appsettings.json")
                .Build();


            // Obtém a string de conexão do appsettings.json
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configura o uso do PostgreSQL
            optionsBuilder.UseNpgsql(connectionString);

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}