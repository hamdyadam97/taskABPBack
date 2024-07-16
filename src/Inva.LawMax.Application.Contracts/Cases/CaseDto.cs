using Inva.LawMax.DtoHearing;
using Inva.LawMax.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Inva.LawMax.DtoCase
{
    public class CaseDto : EntityDto<Guid>
    {
        public long Number { get; set; }
        public int Year { get; set; }
        public LitigationDegreeEnum LitigationDegree { get; set; }
        public string FinalVerdict { get; set; }
        public List<HearingDto> Hearings { get; set; }
      
    }
}
