using dotNetApi.Data;
using dotNetApi.Entities;
using dotNetApi.IRepository;

namespace dotNetApi.Repository;

public class NoteRepository : RepositoryBase<Note>, INoteRepository
{
    private readonly IRepositoryManager _repository;
    
    public NoteRepository(DatabaseContext context) : base(context) { }   
    
    public Task<IEnumerable<Note>> GetNotesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Note> GetNoteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void CreateNoteAsync(Note note)
    {
        CreateAsync(note);
    }

    public Task<Note> UpdateNoteAsync(Note note)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteNoteAsync(int id)
    {
        throw new NotImplementedException();
    }
    
}