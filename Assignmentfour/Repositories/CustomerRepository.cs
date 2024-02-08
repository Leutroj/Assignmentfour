using Assignmentfour.Contexts;
using Assignmentfour.Entities;

namespace Assignmentfour.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }
}
