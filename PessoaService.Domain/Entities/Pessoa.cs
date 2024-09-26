using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaService.Domain.Entities
{
    public class Pessoa
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public string Endereco { get; private set; }

        public Pessoa(string nome, string email, string cpf, string endereco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Endereco = endereco;
        }

        public void AtualizarDados(string nome, string email, string endereco)
        {
            Nome = nome;
            Email = email;
            Endereco = endereco;
        }
    }
}
