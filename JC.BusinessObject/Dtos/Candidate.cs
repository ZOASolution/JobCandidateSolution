using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.BusinessObject.Dtos
{
    public record Candidate
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage ="First Name is Required")]
        [StringLength(10,MinimumLength =2,ErrorMessage ="First Name must be at least 2 letters")]
        public string FirstName { get; set; } = default!;
        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Last Name must be at least 2 letters")]
        public string LastName { get; set; } = default!;
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="Email is Required")]
        [EmailAddress(ErrorMessage ="Pleae Enter Valid Email")]
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
        [DataType(DataType.Url)]
        public string LinkedInProfile { get; set; } = default!;
        [DataType(DataType.Url)]
        public string GithubProfile { get; set; } = default!;
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString ="hh:mm tt")]
        public TimeOnly PreferedTime { get; set; } = default!;
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage ="Please Enter a brief introduction about yourself")]
        public string Comments { get; set; } = default!;
    }
}
