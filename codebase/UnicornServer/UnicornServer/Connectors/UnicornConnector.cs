using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using UnicornServer.Models;

namespace UnicornServer.Connectors
{
  /// <summary>
  /// Offers Unicorns specific database access
  /// Autor: Franziska Haaf
  /// </summary>
  public class UnicornConnector
  {
    /// <summary>
    /// The context to access the database
    /// </summary>
    public DatabaseContext Context { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="context">To be injected</param>
    public UnicornConnector(DatabaseContext context)
    {
      Context = context;
    }

    /// <summary>
    /// Gets all unicorns from the DB
    /// </summary>
    /// <returns>A list of Unicorn</returns>
    public List<Unicorn> GetAllUnicorns()
    {
      return Context.Unicorns.ToList();
    }

    /// <summary>
    /// Add a unicorn to the DB
    /// </summary>
    public Unicorn AddUnicorn(Unicorn unicorn)
    {
      var result = Context.Unicorns.Add(unicorn);
      Context.SaveChanges();
      return result;
    }

    public Unicorn GetUnicornById(int id)
    {
      return Context.Unicorns.Find(id);
    }
  }
}
