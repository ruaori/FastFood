using FastFood.Core.Data;
using FastFood.Core.Models;
using FastFood.DataAccess.Repositories.Interfaces;

namespace FastFood.DataAccess.Repositories.Implements
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(FastFoodContext fastFoodContext) : base(fastFoodContext)
        {
        }
    }
}
