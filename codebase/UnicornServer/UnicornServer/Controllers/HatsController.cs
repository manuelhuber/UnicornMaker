using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Connectors;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to hats
  /// </summary>
  [RoutePrefix("v1/hats")]
  public class HatsController : ApiController
  {
    private readonly HatsConnector _connector;

    //    HatsController(HatsConnector xonnector)
    //    {
    //      _connector = connector;
    //    }


    HatsController()
    {
      _connector = new HatsConnector();
    }

    /// <summary>
    /// Returns an array of hats (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Hat[]))]
    public IHttpActionResult GetHats()
    {
      return Ok(_connector.GetAllHats());
    }

    /// <summary>
    /// The image url for the hat with the given ID
    /// </summary>
    [HttpGet]
    [Route("{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetHatImage()
    {
      return InternalServerError(new NotImplementedException());
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPost]
    [Route("")]
    [ResponseType(typeof(Hat))]
    [Authorize]
    public IHttpActionResult AddHat()
    {
      return InternalServerError(new NotImplementedException());
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPut]
    [Route("{id}")]
    [ResponseType(typeof(Hat))]
    [Authorize]
    public IHttpActionResult ModifyHat()
    {
      return InternalServerError(new NotImplementedException());
    }
  }
}