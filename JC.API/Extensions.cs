using JC.BusinessLogic.Contracts.Managers;
using JC.BusinessLogic.Managers;

namespace JC.API
{
    public static class Extensions
    {
        public static void ConfigureServices(this WebApplicationBuilder applicationBuilder)
        {
            applicationBuilder.Services.AddScoped<ICandidateManager, CandidateManager>();
            applicationBuilder.Services.AddLogging();
        }
    }
}
