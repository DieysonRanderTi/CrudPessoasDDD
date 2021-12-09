using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CrudPessoasDDD.MVC.Models
{
    public class PessoaModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo sobrenome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Selecione uma Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "Endereco é obrigatório")]
        public Endereco Endereco { get; set; }
        public Sexo Sexo { get; set; }
    }

    public class PessoaGridModel
    {
        public int Id { get; set; }

        [Display(Name ="Nome Completo")]
        public string NomeCompleto { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        public int EnderecoId { get; set; }

        [Display(Name ="Endereço")]
        public string Endereco { get; set; }

        public string Sexo { get; set; }
    }
}
