using Industry.Domain.Entities;
using System.Linq.Expressions;

namespace Industry.Domain.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task Delete(Guid id);
        Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate);
    }
}