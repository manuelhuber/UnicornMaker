using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
  [RoutePrefix("/options")]
  public class OptionsController : ApiController
  {

    [HttpGet]
    [Route("/unicorns")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetUnicorns ()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }
    [HttpGet]
    [Route("/hats")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetHats()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }
    [HttpGet]
    [Route("/wings")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetWings()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

  }
}