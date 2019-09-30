using Microsoft.EntityFrameworkCore;
using SGC.AppCore.Interfaces;
using SGC.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SGC.Infrastructure.Repository
{
    public class EFRepository<XEntity> : IRepository<XEntity> where XEntity : class
    {
        protected readonly ClienteContext _dbContext;

        public  EFRepository(ClienteContext dbContext)
        {
            _dbContext = dbContext;
        }
        public virtual XEntity Adcionar(XEntity entity)
        {
            _dbContext.Set<XEntity>().Add(entity);
            _dbContext.SaveChanges();
            return entity;

        }

        public virtual void Atualizar(XEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public IEnumerable<XEntity> Buscar(Expression<Func<XEntity, bool>> predicado)
        {
            return _dbContext.Set<XEntity>().Where(predicado).AsEnumerable();
        }

        public virtual XEntity ObterPorId(int id)
        {
            return _dbContext.Set<XEntity>().Find(id);
        }

        public IEnumerable<XEntity> ObterTodos()
        {
            return _dbContext.Set<XEntity>().AsEnumerable();
        }

        public void Remover(XEntity entity)
        {
            _dbContext.Set<XEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
