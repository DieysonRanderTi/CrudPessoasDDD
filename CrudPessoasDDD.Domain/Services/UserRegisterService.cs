using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Repositories;

namespace CrudPessoasDDD.Domain.Services
{
    public class UserRegisterService : ServiceBase<UserRegister>
    {
        private readonly IUserRegisterRepository _userRegisterRepository;

        public UserRegisterService(IUserRegisterRepository userRegisterRepository) : base(userRegisterRepository)
        {
            _userRegisterRepository = userRegisterRepository;
        }
    }
}
