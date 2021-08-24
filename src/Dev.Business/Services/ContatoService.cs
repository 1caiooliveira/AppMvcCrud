using Dev.Business.Interfaces.Repositories;
using Dev.Business.Models;
using Dev.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Interfaces.Services
{
    public class ContatoService : BaseService, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository, INotificador notificador)
            : base(notificador)
        {
            _contatoRepository = contatoRepository;
        }

        public async Task<bool> Adicionar(Contato contato)
        {

            if (_contatoRepository.Buscar(c => c.Nome == contato.Nome 
                                            && c.TelefoneResidencial == contato.TelefoneResidencial
                                            && c.Celular == contato.Celular).Result.Any())
            {
                Notificar("Já existe um contato cadastrado com esses dados.");
                return false;
            }

            await _contatoRepository.Adicionar(contato);
            return true;
        }

        public async Task<bool> Remover(Contato contato)
        {
            if (!_contatoRepository.Buscar(c => c.Nome == contato.Nome
                                            && c.TelefoneResidencial == contato.TelefoneResidencial
                                            && c.Celular == contato.Celular).Result.Any())
            {
                Notificar("Não existe um contato cadastrado com esses dados.");
                return false;
            }

            await _contatoRepository.Remover(contato.Id);
            return true;
        }

        public void Dispose()
        {
            _contatoRepository?.Dispose();
        }
    }
}
