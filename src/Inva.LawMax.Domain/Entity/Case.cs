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
    public class Case : Entity<Guid>
    {
        public long Number { get; set; }
        public int Year { get; set; }
        public LitigationDegreeEnum LitigationDegree { get; set; }
        public string FinalVerdict { get; set; }
        public virtual ICollection<Hearing> Hearings { get; set; }
        public Guid LawyerId { get; set; }
        public virtual Lawyer Lawyer { get; set; }
       
    }
}
