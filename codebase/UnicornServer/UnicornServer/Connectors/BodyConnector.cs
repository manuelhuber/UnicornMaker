using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using UnicornServer.Models;

namespace UnicornServer.Connectors
{
  public class BodyConnector
  {
    DatabaseContext _context;

//    public BodyConnector(DatabaseContext context)
//    {
//      _context = context;
//    }

    public BodyConnector()
    {
      _context = new DatabaseContext();
    }

    public List<Body> GetAllBodies()
    {
      return _context.Bodies.ToList();
    }

    public Body GetBodyById(int id)
    {
      return _context.Bodies.Find(id);
    }
  }
}