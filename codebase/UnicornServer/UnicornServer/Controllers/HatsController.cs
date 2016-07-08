using System;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UnicornServer.Connectors;
using UnicornServer.Models;
using UnicornServer.Util;

namespace UnicornServer.Controllers
{
  /// <summary>
  /// Rest Endpoint for everything related to hats
  /// Autor: Franziska Haaf
  /// </summary>
  [RoutePrefix("v1/hats")]
  public class HatsController : ApiController
  {
    /// <summary>
    /// Connector to the database layer
    /// </summary>
    public HatsConnector Connector { get; set; }

    /// <summary>
    /// Helper class for image streaming
    /// </summary>
    public ImageHandler ImageHandler { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="hatsConnector">To be injected</param>
    /// <param name="imageHandler">To be injected</param>
    public HatsController(HatsConnector hatsConnector, ImageHandler imageHandler)
    {
      Connector = hatsConnector;
      ImageHandler = imageHandler;
    }

    /// <summary>
    /// Returns an array of hats (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Hat[]))]
    public IHttpActionResult GetHats()
    {
      return Ok(Connector.GetAllHats());
    }

    /// <summary>
    /// The image url for the hat with the given ID
    /// </summary>
    [HttpGet]
    [Route("{id}", Name = "getHatImageById")]
    [ResponseType(typeof(object))]
    public HttpResponseMessage GetHatImage(int id)
    {
      return ImageHandler.GetHatImage(id);
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