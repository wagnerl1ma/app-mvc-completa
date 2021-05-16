using DevIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    //para usar o repositório nesse caso, precisa ser filha da class Entity
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity  
    {
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorId(Guid id);
        Task<List<TEntity>> ObterTodos();
        Task Atualizar(TEntity entity);
        Task Remover(Guid id);
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);  //busca por qualquer parametro
        Task<int> SaveChanges();  // int porque retorna o numero de linhas afetadas
    }
}
