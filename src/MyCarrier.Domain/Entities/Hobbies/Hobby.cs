using MyCarrier.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarrier.Domain.Entities.Hobbies
{
    public class Hobby : Auditable
    {
        public string Content { get; set; }
    }
}
