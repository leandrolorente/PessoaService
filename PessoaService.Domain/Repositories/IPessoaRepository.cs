using PessoaService.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaService.Domain.Repositories
{

    public interface IPessoaRepository
    {
        Task<Pessoa> GetByIdAsync(Guid id);
        Task<List<Pessoa>> GetAllAsync();
        Task AddAsync(Pessoa pessoa);
        Task UpdateAsync(Pessoa pessoa);
        Task DeleteAsync(Guid id);
    }
}
