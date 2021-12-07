using CrudPessoasDDD.Application.Interface;
using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Services;

namespace CrudPessoasDDD.Application
{
    public class EnderecoAppService : AppServiceBase<Endereco>, IEnderecoAppService
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoAppService(IEnderecoService enderecoService) : base(enderecoService)
        {
            _enderecoService = enderecoService;
        }
    }
}
