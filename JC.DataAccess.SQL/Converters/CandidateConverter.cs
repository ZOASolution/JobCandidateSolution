using JC.BusinessObject.Dtos;
using JC.DataAccess.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.SQL.Converters
{
    internal class CandidateConverter
    {
        public static Candidate Convert(CandidateModel candidateModel)
        {
            Candidate candidate = new()
            {
                Id = candidateModel.Id,
                Comments = candidateModel.Comments,
                Email   = candidateModel.Email,
                FirstName = candidateModel.FirstName,
                GithubProfile = candidateModel.GithubProfile,
                LastName = candidateModel.LastName,
                LinkedInProfile = candidateModel.LinkedInProfile,
                PhoneNumber = candidateModel.PhoneNumber,
                PreferedTime=candidateModel.PreferedTime,
            };

            return candidate;
        }

        public static CandidateModel Convert(Candidate candidate)
        {
            CandidateModel candidateModel= new()
            {
                Id = candidate.Id,
                Comments = candidate.Comments,
                Email = candidate.Email,
                FirstName = candidate.FirstName,
                GithubProfile = candidate.GithubProfile,
                LastName = candidate.LastName,
                LinkedInProfile = candidate.LinkedInProfile,
                PhoneNumber = candidate.PhoneNumber,
                PreferedTime = candidate.PreferedTime,
            };

            return candidateModel;
        }
    }
}
