using Assignmentfour.Contexts;
using Assignmentfour.Entities;

namespace Assignmentfour.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }
}
