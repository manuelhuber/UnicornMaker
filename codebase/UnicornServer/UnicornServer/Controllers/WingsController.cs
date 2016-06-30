using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to wings
  /// </summary>
  [RoutePrefix("v1/wings")]
  public class WingsController : ApiController
  {
    /// <summary>
    /// Returns an array of wings (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetWings()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    /// <summary>
    /// The image url for the wings with the given ID
    /// </summary>
    [HttpGet]
    [Route("{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetWingsImage()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPost]
    [Route("")]
    [ResponseType(typeof(Option))]
    [Authorize]
    public IHttpActionResult AddWings()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPut]
    [Route("{id}")]
    [ResponseType(typeof(Option))]
    [Authorize]
    public IHttpActionResult ModifyWings()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }
  }
}