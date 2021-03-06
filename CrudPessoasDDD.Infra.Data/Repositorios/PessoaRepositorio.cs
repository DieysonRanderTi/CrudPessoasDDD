using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Repositories;
using CrudPessoasDDD.Infra.Data.Contexto;

namespace CrudPessoasDDD.Infra.Data.Repositorios
{
    public class PessoaRepositorio : RepositorioBase<Pessoa>, IPessoaRepository
    {
        public PessoaRepositorio(CrudPessoasDDDContext crudPessoasDDDContext) : base(crudPessoasDDDContext)
        {
        }
    }
}
