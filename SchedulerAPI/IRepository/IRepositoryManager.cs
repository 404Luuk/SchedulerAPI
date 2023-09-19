namespace dotNetApi.IRepository;

public interface IRepositoryManager
{
    INoteRepository NoteRepository { get; }
    Task SaveAsync();
}