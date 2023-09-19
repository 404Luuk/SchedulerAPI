namespace dotNetApi.Entities;

public class Note
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime CreatedAt = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
    
    // add users later
    // public Guid UserId { get; set; }
    // public User User { get; set; }
}