using EticaretServer.Application.Repositories;
using EticaretServer.Domain.Entities.Common;
using EticaretServer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EticaretServer.Persistence.Repositories
{
    public class ReadRepositories<T> : IReadRepository<T> where T : BaseEntity
    {
        readonly private EticaretServerContext _context;

        public ReadRepositories(EticaretServerContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true) 
        {
            var query=Table.AsQueryable();
            if (!tracking)
                query=Table.AsNoTracking();
            return query;
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true) 
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query= Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(data=>data.Id==Guid.Parse(id));
        }


        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true) 
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query=Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }


        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true) 
        {
           var query=Table.Where(method);
            if(!tracking)
                query=Table.AsNoTracking();
            return query;
        }
        
    }
}
