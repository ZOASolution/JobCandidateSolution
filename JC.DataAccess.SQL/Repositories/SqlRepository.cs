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
    public class SqlRepository<TModel> : IRepository<TModel> where TModel : ModelBase
    {
        public SqlRepository()
        {
            
        }
        public async Task AddAsync(TModel entity)
        {
            using Context context = new Context();
            await context.Set<TModel>().AddAsync(entity);
            context.SaveChanges();
        }
      

        public void Update(TModel entity)
        {
            using Context context = new Context();
            context.Set<TModel>().Update(entity);
            context.SaveChanges();
        }
    }
}
