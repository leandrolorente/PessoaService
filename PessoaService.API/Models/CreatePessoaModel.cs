﻿namespace PessoaService.API.Models
{
    public class CreatePessoaModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
    }
}
