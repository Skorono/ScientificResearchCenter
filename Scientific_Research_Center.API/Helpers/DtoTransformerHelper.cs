using Scientific_Research_Center.API.DTOs;
using Scientific_Research_Center.Core.Models;

namespace Scientific_Research_Center.API.Helpers;

public static class DtoTransformerHelper
{
    public static PatientDto ToDto(this Patient patient)
    {
        return new()
        {
            Address = patient.Address,
            DateOfBirth = patient.DateOfBirth,
            FirstName = patient.FirstName,
            LastName = patient.LastName,
            MiddleName = patient.MiddleName,
            IsMale = patient.IsMale,
            Region = patient.Region.Name
        };
    }

    public static MedicDto ToDto(this Medic medic)
    {
        return new()
        {
            FirstName = medic.FirstName,
            LastName = medic.LastName,
            MiddleName = medic.MiddleName,
            Office = medic.Office.Name,
            Region = medic.Region.Name,
            Specialization = medic.Specialization.Name
        };
    }

}