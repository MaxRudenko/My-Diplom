using Diplom.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom.Domain
{
    public class Message : BaseEntity
    {
        public virtual Team Team { get; set; }
        public virtual ApplicationUser CreateBy { get; set; }
        public string Text { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public MessageType Type { get; set; }
        public virtual List<ReadUserMessage> ReadUserMessages { get; set; }
    }
}
