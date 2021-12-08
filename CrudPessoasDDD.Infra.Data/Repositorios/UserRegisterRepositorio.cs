using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Repositories;
using CrudPessoasDDD.Infra.Data.Contexto;

namespace CrudPessoasDDD.Infra.Data.Repositorios
{
    public class UserRegisterRepositorio : RepositorioBase<UserRegister>, IUserRegisterRepository
    {
        public UserRegisterRepositorio(CrudPessoasDDDContext crudPessoasDDDContext) : base(crudPessoasDDDContext)
        {
        }
    }
}
