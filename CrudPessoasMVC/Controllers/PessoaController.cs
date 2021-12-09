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
            var enderecos = _mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoGridModel>>(_enderecoAppService.GetAll());

            EnderecoGridModel enderecoGridModel = new EnderecoGridModel();

            foreach (var pessoa in pessoas)
            {
                enderecoGridModel.EnderecoCompleto = enderecos.FirstOrDefault(x => x.Id == pessoa.EnderecoId).EnderecoCompleto;
                pessoa.Endereco = enderecoGridModel.EnderecoCompleto;

            }

            return View(pessoas);
        }

        [HttpGet]
        public IActionResult Create(Pessoa pessoa)
        {
            var pessoaModel = _mapper.Map<Pessoa, PessoaModel>(pessoa);
            return View(pessoaModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PessoaModel pessoaModel)
        {
            if (ModelState.IsValid)
            {
                var pessoa = _mapper.Map<PessoaModel, Pessoa>(pessoaModel);
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
            var pessoa = _mapper.Map<Pessoa, PessoaModel>(_pessoaAppService.GetById(id));
            
            var endereco = _enderecoAppService.GetAll().FirstOrDefault(x => x.Id == pessoa.EnderecoId);

            if (endereco != null)
            {
                pessoa.Endereco = endereco;
            }
                
            return View(pessoa);
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
            var pessoa = _mapper.Map<Pessoa, PessoaModel>(_pessoaAppService.GetAll().FirstOrDefault(x => x.Id == id));
            var endereco = _enderecoAppService.GetAll().FirstOrDefault(x => x.Id == pessoa.EnderecoId);

            pessoa.Endereco = endereco;
            if(pessoa == null)
                return NotFound();

            return View(pessoa);
        }

        public IActionResult Delete(int id)
        {
            var pessoa = _mapper.Map<Pessoa, PessoaModel>(_pessoaAppService.GetById(id));
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
