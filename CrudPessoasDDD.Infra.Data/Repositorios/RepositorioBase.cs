using CrudPessoasDDD.Domain.Interfaces;
using CrudPessoasDDD.Infra.Data.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CrudPessoasDDD.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected CrudPessoasDDDContext Db = new CrudPessoasDDDContext();



        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
