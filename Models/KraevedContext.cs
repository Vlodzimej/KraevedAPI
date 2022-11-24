using Microsoft.EntityFrameworkCore;

namespace KraevedAPI.Models;

public class KraevedContext : DbContext
{
    public KraevedContext(DbContextOptions<KraevedContext> options)
        : base(options)
    {
    }

    public DbSet<BusinessObject> BusinessObjects { get; set; } = null!;

    public DbSet<MetaType> MetaTypes { get; set; } = null!;
}