using dotNetApi.DTOs;
using dotNetApi.IRepository;
using dotNetApi.IServices;

namespace dotNetApi.Services;

public class NoteService: INoteService
{
    private readonly INoteRepository _repository;
    
    public NoteService(INoteRepository repository)
    {
        _repository = repository;
    }
    
    public Task<IEnumerable<NoteDTO>> GetNotesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<NoteDTO> GetNoteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<NoteDTO> CreateNoteAsync(NoteForCreationDTO noteForCreationDTO)
    {
        throw new NotImplementedException();
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