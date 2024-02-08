using Assignmentfour.Contexts;
using Assignmentfour.Entities;

namespace Assignmentfour.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }
}
