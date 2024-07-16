using Inva.LawMax.DtoCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Inva.LawMax.Lawyers
{
    public class LawyerDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public List<CaseDto> Cases { get; set; }
    }
}
