using dotNetApi.Data;
using dotNetApi.IRepository;

namespace dotNetApi.Repository;

public sealed class RepositoryManager: IRepositoryManager
{
    private readonly DatabaseContext _context;
    private readonly Lazy<INoteRepository> _noteRepository;

    public RepositoryManager(DatabaseContext context)
    {
        _context = context;
        _noteRepository = new Lazy<INoteRepository>(() => new NoteRepository(_context));
    }
    
    public INoteRepository NoteRepository => _noteRepository.Value;
    
    
    
    public async Task SaveAsync() => await _context.SaveChangesAsync();
}