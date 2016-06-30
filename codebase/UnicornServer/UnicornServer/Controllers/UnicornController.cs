using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to Unicorns
  /// </summary>
  [RoutePrefix("v1/unicorns")]
  public class UnicornController : ApiController
  {
    /// <summary>
    /// Returns the unicorn for the given ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("{id}")]
    [ResponseType(typeof(Unicorn))]
    public IHttpActionResult GetUnicorn(int id)
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    /// <summary>
    /// Adds a new unicorn
    /// </summary>
    /// <param name="unicorn"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("")]
    [ResponseType(typeof(Unicorn))]
    public IHttpActionResult AddUnicorn([FromBody] Unicorn unicorn)
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }
  }
}