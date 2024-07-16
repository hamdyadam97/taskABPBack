using AutoMapper.Internal.Mappers;
using Inva.LawMax.Entity;
using Inva.LawMax.Lawyers;
using Inva.LawMax.ServiceLawyer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Inva.LawMax.LawyerAppService
{
    public class LawyerAppService :
      CrudAppService<
          Lawyer, //The Book entity
         LawyerDto, //Used to show books
          Guid, //Primary key of the book entity
          PagedAndSortedResultRequestDto, //Used for paging/sorting
          CreateUpdateLawyerDto>, //Used to create/update a book
      ILawyerAppService //implement the IBookAppService
    {
        public LawyerAppService(IRepository<Lawyer, Guid> repository)
            : base(repository)
        {

        }
    }
}
