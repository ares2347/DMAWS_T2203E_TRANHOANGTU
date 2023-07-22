using System.Linq.Expressions;

namespace DMAWS_T2203E_TRANHOANGTU.Repositories;

public interface IRepositoryBase<T> where T : class
{
    IQueryable<T> Get(Expression<Func<T, bool>>? expression, int size = 10, int page = 0);
    Task<T?> GetById(int id, CancellationToken _ = default);
    public Task<T?> Create(T entity, CancellationToken cancellationToken = default);
    public Task<T?> Update(T entity, CancellationToken cancellationToken = default);
    public Task<bool> Delete(int id, CancellationToken cancellationToken = default);
}