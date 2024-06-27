using JC.BusinessLogic.Contracts.Managers;
using JC.BusinessObject.Dtos;
using JC.DataAccess.Contracts.Repositories;
using JC.DataAccess.DataAccessFactories;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.BusinessLogic.Managers
{
    public class CandidateManager : ICandidateManager
    {
        private readonly ICandidateRepository _candidateRepository;
        public CandidateManager()
        {
            _candidateRepository= CandidateDataAccessFactory.GetRepository();
        }
        public async Task SaveAsync(Candidate candidate)
        {
            Candidate? existedCandidate=await _candidateRepository.GetByEmailAsync(candidate.Email);
            if (existedCandidate==null)
            {
                await AddAsync(candidate);
            }
            else
            {
                EditExistedCandidate(candidate, existedCandidate);
                Update(candidate);

            }
        }

        private void Update(Candidate candidate)
        {
           _candidateRepository.Update(candidate);
        }

        private static void EditExistedCandidate(Candidate candidate, Candidate? existedCandidate)
        {
            existedCandidate.Comments = candidate.Comments;
            existedCandidate.FirstName = candidate.FirstName;
            existedCandidate.LastName = candidate.LastName;
            existedCandidate.PhoneNumber = candidate.PhoneNumber;
            existedCandidate.GithubProfile = candidate.GithubProfile;
            existedCandidate.LinkedInProfile = candidate.LinkedInProfile;
            existedCandidate.PreferedTime = candidate.PreferedTime;
        }

        private async Task AddAsync(Candidate candidate)
        {
            candidate.Id=Guid.NewGuid();
           await _candidateRepository.AddAsync(candidate);
        }
    }
}
