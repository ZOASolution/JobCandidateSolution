using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.BusinessObject.Dtos
{
    public record BaseDto
    {
        public Guid Id { get; set; }
    }
}
