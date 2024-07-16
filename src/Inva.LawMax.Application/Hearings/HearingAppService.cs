using Inva.LawMax.DtoHearing;
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

namespace Inva.LawMax.Hearings
{
    public class HearingAppService :
      CrudAppService<
          Hearing, //The Book entity
         HearingDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateHearingDto>, //Used to create/update a book
      IHearingAppService //implement the IBookAppService
    {
        public HearingAppService(IRepository<Hearing, Guid> repository)
            : base(repository)
        {

        }
    }
}
