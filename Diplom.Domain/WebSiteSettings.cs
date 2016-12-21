using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain
{
    public class WebSiteSettings : BaseEntity
    {
        public string WebSiteSlogan { get; set; }
        public bool SiteIsOn { get; set; }
        public bool EmailVerification { get; set; }
        public string DropBoxAppKey { get; set; }
        public string DropBoxAppSecret { get; set; }
    }
}
