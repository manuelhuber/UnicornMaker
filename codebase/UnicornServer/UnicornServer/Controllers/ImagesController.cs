using System;
using System.Web.Http;
using System.Web.Http.Description;

namespace UnicornServer.Controllers
{
  [RoutePrefix("/images")]
  public class ImagesController : ApiController
  {
    [HttpGet]
    [Route("/unicorns/{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetUnicorns()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    [HttpGet]
    [Route("/hats/{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetHats()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    [HttpGet]
    [Route("/wings/{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetWings()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }
  }
}