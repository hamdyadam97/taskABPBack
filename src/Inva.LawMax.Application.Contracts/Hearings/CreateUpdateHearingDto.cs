using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inva.LawMax.DtoHearing
{
    public class CreateUpdateHearingDto
    {
        public DateTime Date { get; set; }
        public string Decision { get; set; }
        public Guid CaseId { get; set; }
    }
}
