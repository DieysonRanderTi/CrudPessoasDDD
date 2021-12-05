using CrudPessoasDDD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudPessoasDDD.Infra.Data.Contexto
{
    public class CrudPessoasDDDContext : DbContext
    {
        public CrudPessoasDDDContext()
        {
        }

        public CrudPessoasDDDContext(DbContextOptions<CrudPessoasDDDContext> options) : base(options) { }

        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
