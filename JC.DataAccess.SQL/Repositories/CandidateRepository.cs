using JC.BusinessObject.Dtos;
using JC.DataAccess.Contracts.Models;
using JC.DataAccess.Contracts.Repositories;
using JC.DataAccess.SQL.Converters;
using JC.DataAccess.SQL.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.SQL.Repositories
{
    public class CandidateRepository : Repository<CandidateModel>, ICandidateRepository
    {
        public async Task<Candidate?> GetByEmail(string email)
        {
            Context context = new();
            CandidateModel? candidateModel=await context.Candidates.FindAsync(email);
            Candidate? candidate =candidateModel!=null? CandidateConverter.Convert(candidateModel):null ;
            return candidate;
        }
    }
}
