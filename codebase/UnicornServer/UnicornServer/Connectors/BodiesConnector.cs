using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using UnicornServer.Models;

namespace UnicornServer.Connectors
{
  public class BodiesConnector
  {
    DatabaseContext _context;

//    public BodiesConnector(DatabaseContext context)
//    {
//      _context = context;
//    }

    public BodiesConnector()
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