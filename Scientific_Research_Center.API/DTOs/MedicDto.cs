namespace Scientific_Research_Center.API.DTOs;

public class MedicDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? MiddleName { get; set; }
    public string Specialization { get; set; } = null!;
    public string Office { get; set; } = null!;
    public string Region { get; set; } = null!; 
}