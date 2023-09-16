using System.Linq.Expressions;

namespace FastFood.DataAccess.Repositories.Interfaces
{
    public interface IBaseRepository<T>
    {
        List<T> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        T? FindByID(Guid id);
        IEnumerable<T> GetInclude(Expression<Func<T, bool>> filter, params string[] includeProps);
    }
}
