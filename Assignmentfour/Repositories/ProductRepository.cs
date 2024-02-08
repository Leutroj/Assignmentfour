using Assignmentfour.Contexts;
using Assignmentfour.Entities;

namespace Assignmentfour.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }
}
