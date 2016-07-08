using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using UnicornServer.Models;

namespace UnicornServer.Connectors
{
  /// <summary>
  /// Offers Wings specific database access
  /// Autor: Franziska Haaf
  /// </summary>
  public class WingsConnector
  {
    /// <summary>
    /// The context to access the database
    /// </summary>
    public DatabaseContext Context { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="context">To be injected</param>
    public WingsConnector(DatabaseContext context)
    {
      Context = context;
    }

    /// <summary>
    /// Gets all wings from the DB
    /// </summary>
    /// <returns>A list of Wings</returns>
    public List<Wings> GetAllWings()
    {
      return Context.Wings.ToList();
    }
  }
}