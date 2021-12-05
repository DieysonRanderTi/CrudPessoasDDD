using CrudPessoasDDD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudPessoasDDD.Domain.Entities
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(int id, string rua, string bairro, string cidade, string estado)
        {
            Id = id;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}
