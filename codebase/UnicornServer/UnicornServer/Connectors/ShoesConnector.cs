using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using UnicornServer.Models;

namespace UnicornServer.Connectors
{
  /// <summary>
  /// Offers Shoe specific database access
  /// Autor: Franziska Haaf
  /// </summary>
  public class ShoesConnector
  {
    /// <summary>
    /// The context to access the databse
    /// </summary>
    public DatabaseContext Context { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="context">To be injected</param>
    public ShoesConnector(DatabaseContext context)
    {
      Context = context;
    }

    /// <summary>
    /// Gets all shoes from the DB
    /// </summary>
    /// <returns>A list of Shoes</returns>
    public List<Shoes> GetAllShoes()
    {
      return Context.Shoes.ToList();
    }
  }
}