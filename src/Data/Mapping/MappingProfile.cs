using AutoMapper;

namespace Data.Mapping;

public class MappingProfile : Profile
{

    public MappingProfile()
    {
        // Note mapping profiles > Add to separate file in future
        CreateMap<Entities.Note, DTOs.NoteDTO>();
        CreateMap<DTOs.NoteForCreationDTO, Entities.Note>();
        CreateMap<DTOs.NoteForUpdateDTO, Entities.Note>();
    }
}