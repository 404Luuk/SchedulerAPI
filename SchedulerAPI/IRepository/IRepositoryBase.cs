using System.Linq.Expressions;

namespace dotNetApi.IRepository;

public interface IRepositoryBase<T>
{
    Task<IEnumerable<T>> FindAllAsync();
    Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression);
    void CreateAsync(T entity);
    void UpdateAsync(T entity);
    void DeleteAsync(T entity);
    Task SaveAsync();
}