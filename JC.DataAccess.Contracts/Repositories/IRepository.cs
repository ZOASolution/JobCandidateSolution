﻿using JC.DataAccess.Contracts.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.Contracts.Repositories
{
    public interface IRepository<T> where T : ModelBase
    {
       void UpdateAsync(T entity);
       Task AddAsync(T entity);


    }
}
