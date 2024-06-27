using JC.BusinessObject.Dtos;
using JC.DataAccess.Contracts.Models;
using JC.DataAccess.Contracts.Repositories;
using JC.DataAccess.SQL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.SQL.Repositories
{
    public class SqlRepository<T> : IRepository<T> where T : BaseDto
    {
        public SqlRepository()
        {
            
        }
        public async Task AddAsync(T entity)
        {
            using Context context = new Context();
            await context.Set<T>().AddAsync(entity);
            context.SaveChanges();
        }
      

        public void Update(T entity)
        {
            using Context context = new Context();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
