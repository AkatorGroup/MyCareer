using MyCarrier.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarrier.Domain.Entities.Chats
{
    public class Chat : Auditable
    {
        public int FreelancerId { get; set; }
        public int CompanyId { get; set; }
        public int MessageId { get; set; }
    }
}
