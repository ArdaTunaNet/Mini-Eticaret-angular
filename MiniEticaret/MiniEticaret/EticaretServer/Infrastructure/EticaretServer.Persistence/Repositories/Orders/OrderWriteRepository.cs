using EticaretServer.Application.Repositories.Orders;
using EticaretServer.Domain.Entities;
using EticaretServer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretServer.Persistence.Repositories.Orders
{
    public class OrderWriteRepository : WriteRepositories<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EticaretServerContext context) : base(context)
        {
        }
    }
}
