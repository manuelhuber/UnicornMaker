using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;
using UnicornServer.Connectors;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to Unicorns
  ///
  /// Autor: Franziska Haaf
  /// </summary>
  [RoutePrefix("v1/unicorns")]
  public class UnicornController : ApiController
  {
    /// <summary>
    /// Connector to the database layer
    /// </summary>
    public UnicornConnector Connector { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="unicornConnector">To be injected</param>
    /// <param name="imageHandler">To be injected</param>
    public UnicornController(UnicornConnector unicornConnector)
    {
      Connector = unicornConnector;
    }

    /// <summary>
    /// Returns the unicorn for the given ID
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("{id}", Name = "getUnicornById")]
    [ResponseType(typeof(Unicorn))]
    public Unicorn GetUnicorn(int id)
    {
      return Connector.GetUnicornById(id);
    }

    /// <summary>
    /// Adds a new unicorn
    /// </summary>
    /// <param name="unicorn"></param>
    /// <returns></returns>
    [HttpPost]
    [Route("")]
    [ResponseType(typeof(Unicorn))]
    public CreatedNegotiatedContentResult<Unicorn> AddUnicorn([FromBody] Unicorn unicorn)
    {
      var uni = Connector.AddUnicorn(unicorn);
      var uri = Url.Link("getUnicornById", new {id = uni.Id});
      return Created(uri, uni);
    }
  }
}