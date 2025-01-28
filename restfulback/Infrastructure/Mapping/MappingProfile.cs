using AutoMapper;
using restfulback.Domain;
using restfulback.Domain.Entity;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<DeceasedProfile,DeceasedData>();
    }
}