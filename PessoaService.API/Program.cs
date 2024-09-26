using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PessoaMicroservice.Application.Commands;
using PessoaService.Domain.Repositories;
using PessoaService.Infrastructure.Repositories;
using PessoaService.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Configuração do DbContext com PostgreSQL (ou outro banco de dados)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registro do MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreatePessoaCommandHandler).Assembly));

// Registro do repositório
builder.Services.AddScoped<IPessoaRepository, PessoaRepository>();

// Registro dos controladores
builder.Services.AddControllers();

// Configuração do Swagger e OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Pessoa Microservice API",
        Description = "API para gerenciamento de pessoas no microserviço Pessoa",
        Contact = new OpenApiContact
        {
            Name = "Seu Nome",
            Email = "seu.email@example.com",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Use under LICX",
            Url = new Uri("https://example.com/license")
        }
    });
});

// Build da aplicação
var app = builder.Build();

// Configuração do pipeline HTTP
if (app.Environment.IsDevelopment())
{
    // Ativando Swagger no ambiente de desenvolvimento
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        // Configura o Swagger UI na raiz (http://localhost:7107/)
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "PessoaMicroservice API v1");
        options.RoutePrefix = string.Empty; // Configura o Swagger UI para ficar no caminho raiz
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();