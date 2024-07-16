using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Inva.LawMax.DtoHearing
{
    public class HearingDto : EntityDto<Guid>
    {
        public DateTime Date { get; set; }
        public string Decision { get; set; }
        public Guid CaseId { get; set; }
    }
}
