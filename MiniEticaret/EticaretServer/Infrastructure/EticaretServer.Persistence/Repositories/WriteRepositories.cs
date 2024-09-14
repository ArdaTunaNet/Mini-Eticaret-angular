using EticaretServer.Application.Repositories;
using EticaretServer.Domain.Entities.Common;
using EticaretServer.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretServer.Persistence.Repositories
{
    public class WriteRepositories<T> : IWriteRepository<T> where T : BaseEntity
    {
        readonly private EticaretServerContext _context;

        public WriteRepositories(EticaretServerContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<bool> AddAsyc(T model)
        {
            EntityEntry<T> entityent = await Table.AddAsync(model);
            return entityent.State == EntityState.Added;

        }

        public async Task<bool> AddRAsyc(List<T> model)
        {
            await Table.AddRangeAsync(model);
            return true;
        }

        public bool Remove(T model)
        {
            EntityEntry<T> entityentR = Table.Remove(model);
            return entityentR.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            T model = await Table.FirstOrDefaultAsync(d => d.Id == Guid.Parse(id));
            return Remove(model);

        }

        public bool RemoveRange(List<T> model)
        {
            Table.RemoveRange(model);
            return true;
        }

        public bool Update(T model)
        {
           EntityEntry<T>entityEntryUpd=Table.Update(model);
            return entityEntryUpd.State==EntityState.Modified;
        }

        public async  Task<int> SaveAsync()
        =>await _context.SaveChangesAsync();


    }
}
