namespace Data.IRepository;

public interface IRepositoryManager
{
    INoteRepository NoteRepository { get; }
    Task SaveAsync();
}