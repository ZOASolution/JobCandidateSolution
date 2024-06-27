using JC.DataAccess.Contracts.Repositories;
using JC.DataAccess.SQL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.DataAccessFactories
{
    public class CandidateDataAccessFactory
    {
        public static ICandidateRepository GetRepository(DataBases dataBases = DataBases.SQL)
        {
            ICandidateRepository candidateRepository = dataBases switch
            {
                DataBases.SQL => new CandidateSQlRepository(),
                _ => new CandidateSQlRepository(),
            };

            return candidateRepository;
        }
    }
}
