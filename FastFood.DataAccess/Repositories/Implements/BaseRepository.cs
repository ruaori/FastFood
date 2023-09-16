using FastFood.Core.Data;
using FastFood.Core.Models;
using FastFood.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FastFood.DataAccess.Repositories.Implements
{
    public class BaseRepository<T>:IBaseRepository<T> where T : BaseModel
    {
        protected readonly FastFoodContext fastFoodContext;
        protected readonly DbSet<T> entities;
        public BaseRepository(FastFoodContext fastFoodContext)
        {
            this.fastFoodContext = fastFoodContext;
            entities = fastFoodContext.Set<T>();
        }
        public async Task Add(T entity)
        {
            entities.Add(entity);
            await fastFoodContext.SaveChangesAsync();
        }

        // Delete a record with parameter is an object
        public async Task Delete(T entity)
        {
            entities.Remove(entity);
            await fastFoodContext.SaveChangesAsync();
        }

        // Find record with parameter is Id
        public T? FindByID(Guid id)
        {
            return entities.FirstOrDefault(x => x.Id == id);
        }

        // Get all records from model T in database
        public List<T> GetAll()
        {
            return entities.ToList();
        }

        // Modify a record and update into database
        public async Task Update(T entity)
        {
            entities.Update(entity);
            await fastFoodContext.SaveChangesAsync();
        }

        // Config for Include
        public virtual IEnumerable<T> GetInclude(Expression<Func<T, bool>> filter, params string[] includeProps)
        {
            var query = entities.AsQueryable();
            if (includeProps.Length > 0)
            {
                foreach (var prop in includeProps)
                {
                    query = query.Include(prop);
                }
            }
            return query.Where(filter).ToList();
        }
    }
}
