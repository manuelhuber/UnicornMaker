using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Util;

namespace UnicornServer.Controllers
{
  [RoutePrefix("api/v1/images")]
  public class ImagesController : ApiController
  {
    public readonly FileProvider FileProvider;

    ImagesController()
    {
      FileProvider = new FileProvider();
    }

    [HttpGet]
    [Route("bodies/{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetUnicorns()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    [HttpGet]
    [Route("hats/{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetHats()
    {
      return InternalServerError(new Exception("Not yet implemented"));
    }

    [HttpGet]
    [Route("wings/{id}")]
    [ResponseType(typeof(Object))]
    public IHttpActionResult GetWings(int id)
    {
      string fileName = string.Format("{0}.jpg", id);
      if (!FileProvider.Exists(fileName))
        throw new HttpResponseException(HttpStatusCode.NotFound);

      FileStream fileStream = FileProvider.Open(fileName);
      HttpResponseMessage response = new HttpResponseMessage {Content = new StreamContent(fileStream)};
      response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpg");
      response.Content.Headers.ContentLength = FileProvider.GetLength(fileName);
      return Ok(response);
//      return InternalServerError(new Exception("Not yet implemented"));
    }
  }
}