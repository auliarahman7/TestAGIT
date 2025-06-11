using System.Data.Entity;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base("DefaultConnection") { }

    public DbSet<ProduksiMobil> ProduksiMobils { get; set; }
}
 