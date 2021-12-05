using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Enums;
using CrudPessoasDDD.Infra.Data.Contexto;
using System;
using System.Linq;

namespace CrudPessoasDDD.Infra.Data.InitialData
{
    public class SeedingService
    {
        public CrudPessoasDDDContext _crudPessoasDDDContext;
        public SeedingService(CrudPessoasDDDContext crudPessoasDDDContext)
        {
            _crudPessoasDDDContext = crudPessoasDDDContext;
        }

        public void Seed()
        {
            if (_crudPessoasDDDContext.Endereco.Any() || _crudPessoasDDDContext.Pessoa.Any())
            {
                return;
            }

            Endereco endereco = new Endereco(1, "Rua Padrão", "Bairro Padrão", "Cidade Padrão", Estado.MG);

            Pessoa pessoa = new Pessoa(1, "Nome Padrão", "Sobrenome Padrão", new DateTime(2000, 01, 01), endereco, Sexo.Masculino);

            _crudPessoasDDDContext.Endereco.Add(endereco);
            _crudPessoasDDDContext.Pessoa.Add(pessoa);

            _crudPessoasDDDContext.SaveChanges();
        }
    }
}
