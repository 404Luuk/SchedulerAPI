using AutoMapper;
using dotNetApi.DTOs;
using dotNetApi.Entities;
using dotNetApi.IRepository;
using dotNetApi.IServices;

namespace dotNetApi.Services;

public class NoteService: INoteService
{
    private readonly IRepositoryManager _repository;
    private readonly IMapper _mapper;
    
    public NoteService(IRepositoryManager repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    
    public Task<IEnumerable<NoteDTO>> GetNotesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<NoteDTO> GetNoteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<NoteDTO> CreateNoteAsync(NoteForCreationDTO noteForCreationDto)
    {
        var noteEntity = _mapper.Map<Note>(noteForCreationDto);

        _repository.NoteRepository.CreateNoteAsync(noteEntity);
        await _repository.SaveAsync();
        
        return _mapper.Map<NoteDTO>(noteEntity);
    }

    public Task<NoteDTO> UpdateNoteAsync(int id, NoteForUpdateDTO noteForUpdateDTO)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteNoteAsync(int id)
    {
        throw new NotImplementedException();
    }
}