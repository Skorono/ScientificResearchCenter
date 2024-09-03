using Microsoft.EntityFrameworkCore;
using Scientific_Research_Center.Core.Models;

namespace Scientific_Research_Center.DAL.Context;

public sealed class ScientificResearchCenterContext : DbContext
{
    public DbSet<Medic> Medics { get; set; }
    public DbSet<Office> Offices { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Specialization> Specializations { get; set; }

    public ScientificResearchCenterContext(DbContextOptions<ScientificResearchCenterContext> options) : base(options)
    {
        Database.Migrate();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Specialization>().HasData(
            new List<Specialization>()
            {
            });

        base.OnModelCreating(modelBuilder);
    }
}