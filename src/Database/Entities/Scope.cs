namespace Blvckout.BlvckAuth.Database.Entities;

public class Scope
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    
    public ICollection<User>? Users { get; set; }
}