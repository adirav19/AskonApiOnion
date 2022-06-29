using dbfirstTest.Application.Repositories;
using dbfirstTest.Domain.Entities;
using dbfirstTest.Persistance.Context;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbfirstTest.Persistance.Repositories
{
    public  class VardiyaReadRepository : ReadRepository<Vardiya>, IOpcVardiyaReadRepository
    {
        public VardiyaReadRepository(opcContext context) : base(context)
        {
        }
    }
}
