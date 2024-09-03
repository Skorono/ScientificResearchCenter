using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Scientific_Research_Center.Core.Models;

public sealed class Medic
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public int SpecializationId { get; set; }
    public int OfficeId { get; set; }
    public int RegionId { get; set; }

    [JsonIgnore]
    [ForeignKey(nameof(SpecializationId))] public Specialization Specialization { set; get; } = null!;

    [JsonIgnore]
    [ForeignKey(nameof(OfficeId))] public Office Office { get; set; } = null!;

    [JsonIgnore]
    [ForeignKey(nameof(RegionId))] public Region Region { get; set; }
}