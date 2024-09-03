using Scientific_Research_Center.Core.Interfaces;
using Scientific_Research_Center.Core.Models;

namespace Scientific_Research_Center.Core.Services;

public sealed class MedicService : ServiceBase<Medic>
{
    public MedicService(IRepository<Medic> repository) : base(repository)
    {
    }
}