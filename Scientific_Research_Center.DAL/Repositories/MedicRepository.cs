using Microsoft.EntityFrameworkCore;
using Scientific_Research_Center.Core.Models;

namespace Scientific_Research_Center.DAL.Repositories;

public class MedicRepository : EntityRepository<Medic>
{
    public MedicRepository(DbContext context) : base(context)
    {
    }

    public override IEnumerable<Medic> Get()
    {
        return DbSet
            .Include(m => m.Specialization)
            .Include(m => m.Office)
            .Include(m => m.Region);
    }
}