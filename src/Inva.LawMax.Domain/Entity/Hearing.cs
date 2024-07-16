using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Inva.LawMax.Entity
{
    public class Hearing : Entity<Guid>
    {
        public DateTime Date { get; set; }
        public string Decision { get; set; }
        public Guid CaseId { get; set; }
        public virtual Case Case { get; set; }
    }
}
