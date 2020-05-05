namespace IPlanner.Domain.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisponsable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);    
    }
}