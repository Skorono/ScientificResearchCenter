using Microsoft.EntityFrameworkCore;
using Scientific_Research_Center.Core.Models;

namespace Scientific_Research_Center.DAL.Repositories;

public class PatientRepository : EntityRepository<Patient>
{
    public PatientRepository(DbContext context) : base(context)
    {
    }

    public override IEnumerable<Patient> Get()
    {
        return DbSet
            .Include(p => p.Region);
    }
}