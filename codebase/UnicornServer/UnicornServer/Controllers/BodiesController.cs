using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Connectors;
using UnicornServer.Models;
using UnicornServer.Util;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to unicorn bodies
  /// </summary>
  [RoutePrefix("v1/bodies")]
  public class BodyController : ApiController
  {
    private readonly BodiesConnector _connector;
    private readonly ImageHandler _provider;

//    BodyController(BodiesConnector bodyConnector)
//    {
//      _connector = bodyConnector;
//    }


    BodyController()
    {
      _connector = new BodiesConnector();
      _provider = new ImageHandler();
    }

    /// <summary>
    /// Returns an array of bodies (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Body[]))]
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
    public HttpResponseMessage GetBodyImage(int id)
    {
      return _provider.GetBodyImage(id);
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPost]
    [Route("")]
    [ResponseType(typeof(Body))]
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
    [ResponseType(typeof(Body))]
    [Authorize]
    public IHttpActionResult ModifyBody()
    {
      return InternalServerError(new NotImplementedException());
    }
  }
}