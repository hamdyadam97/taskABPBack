using Inva.LawMax.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Inva.LawMax.Entity
{
    public class Lawyer : AggregateRoot<Guid>
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public ICollection<Case> Cases { get; set; }


    }
}
