using AutoMapper;
using Inva.LawMax.Entity;
using Inva.LawMax.DtoCase;
using Inva.LawMax.DtoHearing;
using Inva.LawMax.Lawyers;


namespace Inva.LawMax;

public class LawMaxApplicationAutoMapperProfile : Profile
{
    public LawMaxApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Lawyer, LawyerDto>();
        CreateMap<CreateUpdateLawyerDto, Lawyer>();
        CreateMap<Case,  CaseDto>();
        CreateMap<CreateUpdateCaseDto, Case>();
      
        CreateMap<Hearing, HearingDto>();
        CreateMap<CreateUpdateHearingDto, Hearing>();
      
    }
}
