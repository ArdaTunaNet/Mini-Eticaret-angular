using EticaretServer.Application.Repositories.Products;
using EticaretServer.Domain.Entities;
using EticaretServer.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretServer.Persistence.Repositories.Products
{
    public class ProductWriteRepository : WriteRepositories<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(EticaretServerContext context) : base(context)
        {
        }
    }
}
