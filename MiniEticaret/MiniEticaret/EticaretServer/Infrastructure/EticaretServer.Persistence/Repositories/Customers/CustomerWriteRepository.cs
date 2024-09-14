using EticaretServer.Application.Repositories.Customers;
using EticaretServer.Domain.Entities;
using EticaretServer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretServer.Persistence.Repositories.Customers
{
    public class CustomerWriteRepository : WriteRepositories<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(EticaretServerContext context) : base(context)
        {
        }
    }
}
