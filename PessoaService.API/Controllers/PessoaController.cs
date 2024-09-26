using MediatR;
using Microsoft.AspNetCore.Mvc;
using PessoaService.Application.Commands.CreatePessoa;
using PessoaService.Application.Queries;

namespace PessoaService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PessoaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Cria uma nova pessoa.
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreatePessoaCommand command)
        {
            var pessoaId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = pessoaId }, pessoaId);
        }

        /// <summary>
        /// Obtem uma pessoa pelo Id.
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetPessoaByIdQuery(id);
            var pessoa = await _mediator.Send(query);
            if (pessoa == null)
                return NotFound();

            return Ok(pessoa);
        }
    }
}
