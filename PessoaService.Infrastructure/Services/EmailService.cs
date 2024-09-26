using PessoaService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaService.Infrastructure.Services
{
    public class EmailService : INotificationService
    {
        public async Task EnviarEmailAsync(string destinatario, string assunto, string mensagem)
        {
            // Implementação fictícia de envio de email
            await Task.CompletedTask;
        }
    }
}
