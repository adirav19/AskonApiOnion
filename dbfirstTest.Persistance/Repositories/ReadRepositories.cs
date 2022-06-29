using dbfirstTest.Application.Repositories;
using dbfirstTest.Domain.Entities;
using dbfirstTest.Domain.Entities.Common;
using dbfirstTest.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly opcContext _context;

        public ReadRepository(opcContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();
        

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
            //burada tracking mekanizması çalışacakmı
            //çalışmayacak mı onu belirledik.
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        

        
       
       
  

        public Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            throw new NotImplementedException();
        }

        //burası base entityden gelir

    }
}
