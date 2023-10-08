using Data.DTOs;
using Data.IServices;
using Microsoft.AspNetCore.Mvc;

namespace dotNetApi.Controllers;

[ApiController]
[Route("[controller]")]
public class NotesController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    
    public NotesController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetNotesAsync()
    {
        var notes = await _serviceManager.NoteService.GetNotesAsync();
        return Ok(notes);
    }

    [HttpPost]
    public async Task<IActionResult> CreateNoteAsync([FromBody] NoteForCreationDTO noteForCreationDto)
    {
        var createdNote = await _serviceManager.NoteService.CreateNoteAsync(noteForCreationDto);
        return Ok(createdNote);
    }
}