using Microsoft.EntityFrameworkCore;
using PessoaService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PessoaService.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Pessoa> Pessoas { get;  set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pessoa>(entity =>
            {
                entity.HasKey(e => e.Id); // Exemplo de chave primária
                entity.Property(e => e.Nome).IsRequired().HasMaxLength(100); // Exemplo de configuração de campo
            });
        }
    }
}
