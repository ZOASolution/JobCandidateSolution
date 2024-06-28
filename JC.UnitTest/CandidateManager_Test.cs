using JC.BusinessLogic.Contracts.Managers;
using JC.BusinessLogic.Managers;
using JC.BusinessObject.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.UnitTest
{
    internal class CandidateManager_Test
    {
        private ICandidateManager _candidateManager;

        [SetUp]
        public void Setup()
        {
            _candidateManager = new CandidateManager();
        }

        [Test]
        public async Task SaveAsync_New_Candidate_Test()
        {
            Candidate? candidate =  new()
            {
                Comments="Glad for the Opportinity",
                Email=$"{Guid.NewGuid()}@gmail.com",
                FirstName="test",
                LastName="User",
            };

          await  _candidateManager.SaveAsync(candidate);
         candidate = await _candidateManager.GetByEmailAsync(candidate.Email);
            Assert.IsNotNull(candidate);
        }

        [Test]
        public async Task SaveAsync_Update_Candidate_Test()
        {
            Random random = new();
            string phonenumber = random.Next(100000, 999999).ToString();
            Candidate? candidate = new()
            {
                Comments = "Glad for the Opportinity",
                Email = "test@gmail.com",
                FirstName = "test",
                LastName = "User",
                PhoneNumber = phonenumber
            };

            await _candidateManager.SaveAsync(candidate);
            candidate = await _candidateManager.GetByEmailAsync(candidate.Email);
            Assert.That(true,"not Equal",phonenumber,candidate?.PhoneNumber??string.Empty);
        }
    }
}
