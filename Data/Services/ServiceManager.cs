using AutoMapper;
using dotNetApi.IRepository;
using dotNetApi.IServices;

namespace dotNetApi.Services;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<INoteService> _noteService;

    public ServiceManager(IMapper mapper, IRepositoryManager repositoryManager)
    {
        _noteService = new Lazy<INoteService>(() => new NoteService(repositoryManager, mapper));
    }
    
    public INoteService NoteService => _noteService.Value;
}