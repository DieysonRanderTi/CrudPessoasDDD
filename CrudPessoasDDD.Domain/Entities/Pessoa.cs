using CrudPessoasDDD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrudPessoasDDD.Domain.Entities
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public Sexo Sexo { get; set; }

        public Pessoa(){}

        public Pessoa(int id, string nome, string sobrenome, DateTime dataNascimento, Endereco endereco, Sexo sexo)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Sexo = sexo;
        }
    }
}
