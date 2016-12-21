using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain
{
    public class ReadUserMessage : BaseEntity
    {
        public virtual ApplicationUser User { get; set; }
        [Required]
        public virtual Message Message { get; set; }
        public bool Read { get; set; }
    }
}
