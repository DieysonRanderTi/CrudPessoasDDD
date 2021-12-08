using AutoMapper;
using CrudPessoasDDD.Application.Interface;
using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CrudPessoasDDD.MVC.Controllers
{
    [Authorize]
    public class PessoaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPessoaAppService _pessoaAppService;
        private readonly IEnderecoAppService _enderecoAppService;

        public PessoaController(IMapper mapper,
            IPessoaAppService pessoaAppService,
            IEnderecoAppService enderecoAppService)
        {
            _mapper = mapper;
            _pessoaAppService = pessoaAppService;
            _enderecoAppService = enderecoAppService;
        }

        public IActionResult Index()
        {
            var pessoas = _mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaGridModel>>(_pessoaAppService.GetAll());

            return View(pessoas);
        }

        [HttpGet]
        public IActionResult Create(PessoaModel pessoa)
        {
            return View(pessoa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                _pessoaAppService.Add(pessoa);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Cadastro Inválido","Preencha todos os Campos e tente novamente.");
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            var obj = _pessoaAppService.GetById(id);
            var endereco = _enderecoAppService.GetAll().FirstOrDefault(x => x.Id == obj.EnderecoId);

            if (endereco != null)
            {
                obj.Endereco = endereco;
            }
                
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(int id, Pessoa pessoa)
        {
            _pessoaAppService.Update(pessoa);
            pessoa.Endereco.Id = pessoa.EnderecoId;
            _enderecoAppService.Update(pessoa.Endereco);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var pessoa = _pessoaAppService.GetAll().FirstOrDefault(x => x.Id == id);
            var endereco = _enderecoAppService.GetAll().FirstOrDefault(x => x.Id == pessoa.EnderecoId);

            pessoa.Endereco = endereco;
            if(pessoa == null)
                return NotFound();

            return View(pessoa);
        }

        public IActionResult Delete(int id)
        {
            var pessoa = _pessoaAppService.GetById(id);
            var endereco = _enderecoAppService.GetAll().FirstOrDefault(x => x.Id == pessoa.EnderecoId);
            pessoa.Endereco = endereco;

            return View(pessoa);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed( int id) 
        {
            var pessoa = _pessoaAppService.GetById(id);
            var endereco = _enderecoAppService.GetAll().FirstOrDefault(x => x.Id == pessoa.EnderecoId);

            _pessoaAppService.Remove(pessoa);
            _enderecoAppService.Remove(endereco);

            return RedirectToAction(nameof(Index));
        }
    }
}
