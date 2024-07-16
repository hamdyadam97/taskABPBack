using Inva.LawMax.DtoCase;
using Inva.LawMax.DtoHearing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Inva.LawMax.Hearings
{
    public interface IHearingAppService :
      ICrudAppService< //Defines CRUD methods
          HearingDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateHearingDto> //Used to create/update a book
    {

    }
}
