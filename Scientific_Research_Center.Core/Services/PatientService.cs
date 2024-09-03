using Scientific_Research_Center.Core.Interfaces;
using Scientific_Research_Center.Core.Models;

namespace Scientific_Research_Center.Core.Services;

public sealed class PatientService : ServiceBase<Patient>
{
    public PatientService(IRepository<Patient> repository) : base(repository)
    {
    }
}