using CrudPessoasDDD.Domain.Interfaces.Repositories;
using CrudPessoasDDD.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudPessoasDDD.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected CrudPessoasDDDContext _crudPessoasDDDContext;

        public RepositorioBase(CrudPessoasDDDContext crudPessoasDDDContext)
        {
            _crudPessoasDDDContext = crudPessoasDDDContext;
        }

        public void Add(TEntity obj)
        {
            _crudPessoasDDDContext.Set<TEntity>().Add(obj);
            _crudPessoasDDDContext.SaveChanges();
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _crudPessoasDDDContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _crudPessoasDDDContext.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            _crudPessoasDDDContext.Set<TEntity>().Remove(obj);
            _crudPessoasDDDContext.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _crudPessoasDDDContext.Entry(obj).State = EntityState.Modified;
            _crudPessoasDDDContext.SaveChanges();
        }
    }
}
