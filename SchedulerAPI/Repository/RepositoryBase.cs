using System.Linq.Expressions;
using dotNetApi.Data;
using dotNetApi.IRepository;

namespace dotNetApi.Repository;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    protected DatabaseContext _context;
    
    public RepositoryBase(DatabaseContext context)
    {
        _context = context;
    }
    
    public Task<IEnumerable<T>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> FindByConditionAsync(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public void CreateAsync(T entity)
    {
        // performance issue? <<
        _context.Set<T>().AddAsync(entity);
    }

    public void UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public void DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task SaveAsync()
    {
        throw new NotImplementedException();
    }
}