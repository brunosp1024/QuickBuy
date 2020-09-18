using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    //Interface base para assinatura de todas as classes repositórios das entidades.
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class //onde TEntity é uma classe 
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int Id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Deletar(TEntity entity);
    }
}
