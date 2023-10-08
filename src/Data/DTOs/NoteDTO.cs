namespace Data.DTOs;

public record NoteDTO
{
    public Guid Id { get; init; }
    public string Title { get; init; }
    public string Content { get; init; }
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; init; }
};