using MediatR;
using PessoaService.Application.Commands.CreatePessoa;
using PessoaService.Domain.Entities;
using PessoaService.Domain.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace PessoaMicroservice.Application.Commands
{
    public class CreatePessoaCommandHandler : IRequestHandler<CreatePessoaCommand, Guid>
    {
        private readonly IPessoaRepository _pessoaRepository;

        public CreatePessoaCommandHandler(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public async Task<Guid> Handle(CreatePessoaCommand request, CancellationToken cancellationToken)
        {
            var pessoa = new Pessoa(request.Nome, request.Email, request.Cpf, request.Endereco);
            await _pessoaRepository.AddAsync(pessoa);
            return pessoa.Id;
        }
    }
}