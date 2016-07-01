using System.Data.Entity;


namespace UnicornServer.Models
{
  public class DatabaseContext : DbContext
  {
    public DatabaseContext() : base("DatabaseContext")
    {
    }

    public DbSet<Body> Bodies { get; set; }
    public DbSet<Hat> Hats { get; set; }
    public DbSet<Wings> Wings { get; set; }
    public DbSet<Shoes> Shoes { get; set; }
  }
}