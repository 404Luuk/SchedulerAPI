using dotNetApi.Entities;
using dotNetApi.IRepository;

namespace dotNetApi.Repository;

public class NoteRepository : INoteRepository
{
    
    
    public Task<IEnumerable<Note>> GetNotesAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Note> GetNoteByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Note> CreateNoteAsync(Note note)
    {
        throw new NotImplementedException();
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