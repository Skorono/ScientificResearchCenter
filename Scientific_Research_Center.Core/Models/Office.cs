using Microsoft.EntityFrameworkCore;

namespace Scientific_Research_Center.Core.Models;

[Index(nameof(Name), IsUnique = true)]
public sealed class Office
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}