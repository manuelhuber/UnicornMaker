using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using UnicornServer.Models;

namespace UnicornServer.Connectors
{
  /// <summary>
  /// Offers Body specific database access
  /// </summary>
  public class BodiesConnector
  {
    /// <summary>
    /// The context to access the databse
    /// </summary>
    public DatabaseContext Context { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="context">To be injected</param>
    public BodiesConnector(DatabaseContext context)
    {
      Context = context;
    }

    /// <summary>
    /// Gets all bodies from the DB
    /// </summary>
    /// <returns>A list of Bodies</returns>
    public List<Body> GetAllBodies()
    {
      return Context.Bodies.ToList();
    }
  }
}