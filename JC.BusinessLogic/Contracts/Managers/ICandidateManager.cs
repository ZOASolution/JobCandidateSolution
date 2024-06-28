using JC.BusinessObject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.BusinessLogic.Contracts.Managers
{
    public interface ICandidateManager
    {
        Task<Candidate?> GetByEmailAsync(string email);
        Task SaveAsync(Candidate candidate);
    }
}
