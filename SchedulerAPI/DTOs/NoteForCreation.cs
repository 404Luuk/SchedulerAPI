using System.ComponentModel.DataAnnotations;

namespace dotNetApi.DTOs;

public class NoteForCreation
{
    [Required]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }
}