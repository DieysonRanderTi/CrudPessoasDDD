using CrudPessoasDDD.Application.Interface;
using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces.Services;

namespace CrudPessoasDDD.Application
{
    public class UserResgisterAppService : AppServiceBase<UserRegister>, IUserRegisterAppService
    {
        private readonly IUserRegisterService _userRegisterService;

        public UserResgisterAppService(IUserRegisterService userRegisterService) : base(userRegisterService)
        {
            _userRegisterService = userRegisterService;
        }
    }
}
