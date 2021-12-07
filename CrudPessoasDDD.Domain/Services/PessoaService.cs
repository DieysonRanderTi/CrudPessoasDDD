using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Repositories;
using CrudPessoasDDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudPessoasDDD.Domain.Services
{
    public class PessoaService : ServiceBase<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository) : base(pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }
    }
}
