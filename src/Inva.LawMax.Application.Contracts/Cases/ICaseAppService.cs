using Inva.LawMax.DtoCase;
using Inva.LawMax.Lawyers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Inva.LawMax.Cases
{
    public interface ICaseAppService :
      ICrudAppService< //Defines CRUD methods
          CaseDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateCaseDto> //Used to create/update a book
    {

    }
}
