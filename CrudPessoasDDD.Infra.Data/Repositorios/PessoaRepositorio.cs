using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudPessoasDDD.Infra.Data.Repositorios
{
    public class PessoaRepositorio : RepositorioBase<Pessoa>, IPessoaRepository
    {
    }
}
