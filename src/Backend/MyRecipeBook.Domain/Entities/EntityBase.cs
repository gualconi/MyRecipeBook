namespace MyRecipeBook.Domain.Entities;

public class EntityBase
{
    public long Id { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
}
