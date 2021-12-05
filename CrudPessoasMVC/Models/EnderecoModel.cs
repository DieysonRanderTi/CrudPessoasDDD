using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudPessoasDDD.MVC.Models
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string CidadeEstado { get; set; }
    }
}
