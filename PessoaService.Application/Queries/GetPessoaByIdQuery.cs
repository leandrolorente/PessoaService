using MediatR;
using PessoaService.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaService.Application.Queries
{
    /// <summary>
    /// Query para obter uma pessoa pelo Id.
    /// </summary>
    public class GetPessoaByIdQuery : IRequest<PessoaDto>
    {
        public Guid Id { get; set; }

        public GetPessoaByIdQuery(Guid id)
        {
            Id = id;
        }
    }
}
