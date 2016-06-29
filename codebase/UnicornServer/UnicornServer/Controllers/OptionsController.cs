using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  [RoutePrefix("api/v1/options")]
  public class OptionsController : ApiController
  {
    /// <summary>
    /// Not yet implemented
    /// </summary>
    [HttpGet]
    [Route("bodies")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetUnicorns()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }


    /// <summary>
    /// Not yet implemented
    /// </summary>
    [HttpGet]
    [Route("hats")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetHats()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }


    /// <summary>
    /// Not yet implemented
    /// </summary>
    [HttpGet]
    [Route("wings")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetWings()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }
  }
}