using MyCarrier.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarrier.Domain.Entities.Companies
{
    public class Company : Auditable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int ImageId { get; set; }
        public int UserId { get; set; }
        public int ContactId { get; set; }
        public int CompanyInformationId { get; set; }
    }
}
