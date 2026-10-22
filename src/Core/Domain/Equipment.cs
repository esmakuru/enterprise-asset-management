namespace Domain;

public class Equipment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string SerialNumber { get; set; } = string.Empty;
    public bool IsAssigned { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}