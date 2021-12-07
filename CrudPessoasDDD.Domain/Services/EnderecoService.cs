using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Repositories;
using CrudPessoasDDD.Domain.Interfaces.Services;

namespace CrudPessoasDDD.Domain.Services
{
    public class EnderecoService : ServiceBase<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository) : base(enderecoRepository)
        {
            _enderecoRepository = enderecoRepository;
        }
    }
}
