namespace Scientific_Research_Center.API.DTOs;

public class PatientDto
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? MiddleName { get; set; }

    public DateOnly DateOfBirth { get; set; }
    public string Address { get; set; } = null!;
    public bool IsMale { get; set; }

    public string Region { get; set; } = null!;
}