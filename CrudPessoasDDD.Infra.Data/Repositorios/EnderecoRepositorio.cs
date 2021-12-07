using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Repositories;
using CrudPessoasDDD.Infra.Data.Contexto;

namespace CrudPessoasDDD.Infra.Data.Repositorios
{
    public class EnderecoRepositorio : RepositorioBase<Endereco>, IEnderecoRepository
    {
        public EnderecoRepositorio(CrudPessoasDDDContext crudPessoasDDDContext) : base(crudPessoasDDDContext)
        {
        }
    }
}
