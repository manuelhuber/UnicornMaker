using System.Data.Entity;

namespace UnicornServer.Models
{
  /// <summary>
  /// Database access
  /// </summary>
  public class DatabaseContext : DbContext
  {
    /// <summary>
    /// The databse for Body
    /// </summary>
    public DbSet<Body> Bodies { get; set; }

    /// <summary>
    /// The databse for Hat
    /// </summary>
    public DbSet<Hat> Hats { get; set; }

    /// <summary>
    /// The databse for Wings
    /// </summary>
    public DbSet<Wings> Wings { get; set; }

    /// <summary>
    /// The databse for Shoes
    /// </summary>
    public DbSet<Shoes> Shoes { get; set; }

    /// <summary>
    /// The databse for Unicorn
    /// </summary>
    public DbSet<Unicorn> Unicorns { get; set; }

    /// <summary>
    /// Default constructor, getting the connection string from the config
    /// </summary>
    public DatabaseContext() : base("DatabaseContext")
    {
    }

    static DatabaseContext()
    {
      Database.SetInitializer(new DbInitializer());
    }
  }
}