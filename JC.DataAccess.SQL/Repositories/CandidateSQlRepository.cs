using JC.BusinessObject.Dtos;
using JC.DataAccess.Contracts.Models;
using JC.DataAccess.Contracts.Repositories;
using JC.DataAccess.SQL.Converters;
using JC.DataAccess.SQL.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.SQL.Repositories
{
    public class CandidateSQlRepository : SqlRepository<CandidateModel>, ICandidateRepository
    {
        public async Task<Candidate?> GetByEmailAsync(string email)
        {
            Context context = new();
            CandidateModel? candidateModel=await context.Candidates.FirstOrDefaultAsync(candidate=>candidate.Email==email);
            Candidate? candidate =candidateModel!=null? CandidateConverter.Convert(candidateModel):null ;
            return candidate;
        }

       
        public async Task AddAsync(Candidate candidate)
        {
            CandidateModel model = CandidateConverter.Convert(candidate);
            await base.AddAsync(model);
        }

        public void Update(Candidate candidate)
        {
            CandidateModel model = CandidateConverter.Convert(candidate);
            
            base.Update(model);
        }
    }
}
