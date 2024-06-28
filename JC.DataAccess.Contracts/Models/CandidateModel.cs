using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DataAccess.Contracts.Models
{
    [Table("Candidates")]
    public partial class CandidateModel: ModelBase
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? PhoneNumber { get; set; }
        public string? LinkedInProfile { get; set; }
        public string? GithubProfile { get; set; } 
        public TimeOnly? PreferedTime { get; set; }
        public string Comments { get; set; } = default!;
    }
}
