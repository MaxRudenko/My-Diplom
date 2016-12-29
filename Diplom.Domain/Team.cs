using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain
{
    public class Team : BaseEntity
    {
        public string Abbreviation { get; set; }
        public string IconColorHex { get; set; }
        public string TeamName { get; set; }
        public virtual ApplicationUser Admin { get; set; }
        public virtual DropBoxAccount DropBoxAccount { get; set; }
    }
}
