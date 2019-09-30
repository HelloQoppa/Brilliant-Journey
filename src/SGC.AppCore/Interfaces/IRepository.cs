using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SGC.AppCore.Interfaces
{
    public interface IRepository<XEntity> where XEntity :class
    {
        XEntity Adcionar(XEntity entity);
        void Atualizar(XEntity entity);
        IEnumerable<XEntity>ObterTodos();
        XEntity ObterPorId(int id);
        IEnumerable<XEntity> Buscar(Expression<Func<XEntity,bool>>predicado);
        void Remover(XEntity entity);



    }
}
