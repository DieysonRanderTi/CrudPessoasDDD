using CrudPessoasDDD.Domain.Entities;
using CrudPessoasDDD.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPessoasDDD.MVC.Models
{
    public class PessoaModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Preencha o campo nome")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(50, ErrorMessage = "Máximo {0} caracteres")]
        public string Sobrenome { get; set; }

        [Display(Name ="Data de nascimento")]
        [Required(ErrorMessage = "Selecione uma Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        public int EnderecoId { get; set; }
        public Endereco Endereco { get; set; }
        public Sexo Sexo { get; set; }
    }
}
