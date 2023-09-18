namespace dotNetApi.DTOs;

public record NoteDTO
{
    public int Id { get; init; }
    public string Title { get; init; }
    public string Content { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
};