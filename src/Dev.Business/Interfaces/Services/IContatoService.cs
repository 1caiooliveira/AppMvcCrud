using Dev.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces.Services
{
    public interface IContatoService : IDisposable
    {
        Task<bool> Adicionar(Contato contato);
        Task<bool> Remover(Contato contato);


    }
}
