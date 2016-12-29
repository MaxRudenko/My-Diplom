using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain
{
    public class TeamMember : BaseEntity
    {
        public virtual ApplicationUser User { get; set; }
        public string Abbreviation { get; set; }
        public string IconColorHex { get; set; }
    }
}
