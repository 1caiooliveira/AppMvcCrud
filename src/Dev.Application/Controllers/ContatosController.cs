using AutoMapper;
using Dev.Application.ViewModels;
using Dev.Business.Interfaces.Repositories;
using Dev.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Application.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoRepository _contatoRepository;
        private readonly IMapper _mapper;


        public ContatosController(IContatoRepository contatoRepository, IMapper mapper)
        {
            _contatoRepository = contatoRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ContatoViewModel>>(await _contatoRepository.ObterTodos()));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContatoViewModel contatoViewModel)
        {
            if (!ModelState.IsValid) return View(contatoViewModel);

            var contato = _mapper.Map<Contato>(contatoViewModel);
            await _contatoRepository.Adicionar(contato);

            return RedirectToAction("Index");
        }
    
        public async Task<IActionResult> Delete(Guid id)
        {
            var contatoViewModel = _mapper.Map<ContatoViewModel>(await _contatoRepository.ObterPorId(id));
            if (contatoViewModel ==  null)
            {
                return NotFound();
            }

            return View(contatoViewModel);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(ContatoViewModel contatoViewModel)
        {
            await _contatoRepository.Remover(contatoViewModel.Id);

            return RedirectToAction("Index");

        }
    
    }
}
