using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Inva.LawMax.Lawyers
{
    public interface ILawyerAppService :
     ICrudAppService< //Defines CRUD methods
         LawyerDto, //Used to show books
         Guid, //Primary key of the book entity
         PagedAndSortedResultRequestDto, //Used for paging/sorting
         CreateUpdateLawyerDto> //Used to create/update a book
    {
        
    }
}
