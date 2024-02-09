﻿using Assignmentfour.Contexts;
using Assignmentfour.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace Assignmentfour.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public override CustomerEntity Get(Expression<Func<CustomerEntity, bool>> expression)
        {
            var entity = _context.Customers
                .Include(i => i.Address)
                .Include(i => i.Role)
                .FirstOrDefault(expression);

            return entity!;
        }

        public override IEnumerable<CustomerEntity> GetAll()
        {
            return _context.Customers
                .Include(i => i.Address)
                .Include(i => i.Role)
                .ToList();
        }
    }
}
