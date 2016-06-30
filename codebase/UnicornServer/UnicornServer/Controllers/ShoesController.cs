using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to shoes
  /// </summary>
  [RoutePrefix("v1/shoes")]
  public class ShoesController : ApiController
  {
    /// <summary>
    /// Returns an array of shoes (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetShoes()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    /// <summary>
    /// The image url for the shoes with the given ID
    /// </summary>
    [HttpGet]
    [Route("{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetShoesImage()
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
    public IHttpActionResult AddShoes()
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
    public IHttpActionResult ModifyShoes()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }
  }
}