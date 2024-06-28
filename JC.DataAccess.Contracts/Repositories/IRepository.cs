using JC.BusinessObject.Dtos;
using JC.DataAccess.Contracts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.Contracts.Repositories
{
    public interface IRepository<TModel> where TModel : ModelBase
    {
       void Update(TModel entity);
       Task AddAsync(TModel entity);


    }
}
