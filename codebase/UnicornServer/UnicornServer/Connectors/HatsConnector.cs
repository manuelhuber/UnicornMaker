using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using UnicornServer.Models;

namespace UnicornServer.Connectors
{
  public class HatsConnector
  {
    DatabaseContext _context;

    public HatsConnector(DatabaseContext context)
    {
      _context = context;
    }

    public List<Hat> GetAllHats()
    {
      return _context.Hats.ToList();
    }

    public Hat GetHatById(int id)
    {
      return _context.Hats.Find(id);
    }
  }
}