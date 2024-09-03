using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Scientific_Research_Center.Core.Models;

public sealed class Patient
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? MiddleName { get; set; }

    public DateOnly DateOfBirth { get; set; }
    public string Address { get; set; } = null!;
    public bool IsMale { get; set; }

    public int RegionId { get; set; }

    [JsonIgnore]
    [ForeignKey(nameof(RegionId))] public Region Region { get; set; } = null!;
}