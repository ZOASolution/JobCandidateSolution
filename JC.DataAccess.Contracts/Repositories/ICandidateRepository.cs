﻿using JC.BusinessObject.Dtos;
using JC.DataAccess.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.Contracts.Repositories
{
    public interface ICandidateRepository
    {
        Task<Candidate?> GetByEmail(string email);
    }
}
