using dotNetApi.DTOs;

namespace dotNetApi.IServices;

public interface INoteService
{
    Task<IEnumerable<NoteDTO>> GetNotesAsync();
    Task<NoteDTO> GetNoteByIdAsync(int id);
    Task<NoteDTO> CreateNoteAsync(NoteForCreationDTO noteForCreationDTO);
    Task<NoteDTO> UpdateNoteAsync(int id, NoteForUpdateDTO noteForUpdateDTO);
    Task<bool> DeleteNoteAsync(int id);
}