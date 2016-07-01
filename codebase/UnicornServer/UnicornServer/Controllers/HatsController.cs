using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to hats
  /// </summary>
  [RoutePrefix("v1/hats")]
  public class HatsController : ApiController
  {
    /// <summary>
    /// Returns an array of hats (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetHats()
    {
      return InternalServerError(new NotImplementedException());
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
    [ResponseType(typeof(Option))]
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
    [ResponseType(typeof(Option))]
    [Authorize]
    public IHttpActionResult ModifyHat()
    {
      return InternalServerError(new NotImplementedException());
    }
  }
}