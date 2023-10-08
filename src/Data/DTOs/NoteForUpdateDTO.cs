using System.ComponentModel.DataAnnotations;

namespace Data.DTOs;

public record NoteForUpdateDTO
{
    [Required]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }
    
};