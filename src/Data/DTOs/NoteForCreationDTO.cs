using System.ComponentModel.DataAnnotations;

namespace Data.DTOs;

public class NoteForCreationDTO
{
    [Required]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }
}