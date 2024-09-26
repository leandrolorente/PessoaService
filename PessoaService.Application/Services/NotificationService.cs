using PessoaService.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaService.Application.Services
{
    public class NotificationService : INotificationService
    {
        public async Task EnviarEmailAsync(string destinatario, string assunto, string mensagem)
        {
            // Implementação fictícia de envio de email
            await Task.CompletedTask;
        }
    }
}
