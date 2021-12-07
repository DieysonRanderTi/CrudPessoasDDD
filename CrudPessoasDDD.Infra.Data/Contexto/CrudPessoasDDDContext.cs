using CrudPessoasDDD.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrudPessoasDDD.Infra.Data.Contexto
{
    public class CrudPessoasDDDContext : IdentityDbContext
    {
        public CrudPessoasDDDContext(DbContextOptions<CrudPessoasDDDContext> options) : base(options) { }

        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
