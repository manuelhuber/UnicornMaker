using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Connectors;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to unicorn bodies
  /// </summary>
  [RoutePrefix("v1/bodies")]
  public class BodyController : ApiController
  {
    private readonly BodyConnector _connector;

//    BodyController(BodyConnector bodyConnector)
//    {
//      _connector = bodyConnector;
//    }


    BodyController()
    {
      _connector = new BodyConnector();
    }

    /// <summary>
    /// Returns an array of bodies (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetBodies()
    {
      return Ok(_connector.GetAllBodies());
    }

    /// <summary>
    /// The image url for the body with the given ID
    /// </summary>
    [HttpGet]
    [Route("{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetBodyImage()
    {
      return InternalServerError(new NotImplementedException());
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPost]
    [Route("")]
    [ResponseType(typeof(Option))]
    [Authorize]
    public IHttpActionResult AddBody()
    {
      return InternalServerError(new NotImplementedException());
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPut]
    [Route("{id}")]
    [ResponseType(typeof(Option))]
    [Authorize]
    public IHttpActionResult ModifyBody()
    {
      return InternalServerError(new NotImplementedException());
    }
  }
}