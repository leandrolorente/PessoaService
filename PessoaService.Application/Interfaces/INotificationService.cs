using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaService.Application.Interfaces
{
    public interface INotificationService
    {
        Task EnviarEmailAsync(string destinatario, string assunto, string mensagem);
    }
}
