using FastFood.Core.Data;
using FastFood.Core.Models;
using FastFood.DataAccess.Repositories.Interfaces;

namespace FastFood.DataAccess.Repositories.Implements
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(FastFoodContext fastFoodContext) : base(fastFoodContext)
        {
        }
    }
}
