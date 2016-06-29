using System;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Models;

namespace UnicornServer.Controllers
{
//  <summary>
//  Not part of v1 release
//  </summary>
  [RoutePrefix("api/v0/admin")]
  public class AdminController : ApiController
  {
    /// <summary>
    /// Not yet implemented
    /// </summary>
    [HttpPost]
    [Route("bodies")]
    [ResponseType(typeof(Option))]
    public IHttpActionResult AddUnicorns()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    [HttpPut]
    [Route("bodies/{id}")]
    [ResponseType(typeof(Option))]
    public IHttpActionResult GetUnicorns()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    /// <summary>
    /// Not yet implemented
    /// </summary>
    [HttpPost]
    [Route("hats")]
    [ResponseType(typeof(Option))]
    public IHttpActionResult AddHats()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    [HttpPut]
    [Route("hats/{id}")]
    [ResponseType(typeof(Option))]
    public IHttpActionResult GetHats()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }


    /// <summary>
    /// Not yet implemented
    /// </summary>
    [HttpPost]
    [Route("wings")]
    [ResponseType(typeof(Option))]
    public IHttpActionResult AddWings()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    [HttpPut]
    [Route("wings/{id}")]
    [ResponseType(typeof(Option))]
    public IHttpActionResult GetWings(int id)
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }
  }
}