using MyCarrier.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarrier.Domain.Entities.Attachments
{
    public class Attachment : Auditable
    {
        public string Path { get; set; }
    }
}
