using MyCarrier.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarrier.Domain.Entities.Regions
{
    public class Region : Auditable
    {
        public string Name { get; set; }
    }
}
