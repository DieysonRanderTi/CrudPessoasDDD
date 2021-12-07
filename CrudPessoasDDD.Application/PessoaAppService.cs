using CrudPessoasDDD.Application.Interface;
using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Services;

namespace CrudPessoasDDD.Application
{
    public class PessoaAppService : AppServiceBase<Pessoa>, IPessoaAppService
    {
        private readonly IPessoaService _pessoaService;

        public PessoaAppService(IPessoaService pessoaService) : base(pessoaService)
        {
            _pessoaService = pessoaService;
        }
    }
}
