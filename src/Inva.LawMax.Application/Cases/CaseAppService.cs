using Inva.LawMax.DtoCase;
using Inva.LawMax.Entity;
using Inva.LawMax.Lawyers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Inva.LawMax.Cases
{
    public class CaseAppService :
        CrudAppService<
            Case, //The Case entity
            CaseDto, //Used to show cases
            Guid, //Primary key of the case entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCaseDto>, //Used to create/update a case
        ICaseAppService //implement the ICaseAppService
    {
        public CaseAppService(IRepository<Case, Guid> repository)
            : base(repository)
        {
        }
    }
}
