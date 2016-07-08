using System;
using System.Collections.Generic;
using System.Net.Http;
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
  public class BodiesController : ApiController
  {
    public BodiesConnector Connector { get; set; }
    public ImageHandler ImageHandler { get; set; }
//    private readonly BodiesConnector _connector;
//    private readonly ImageHandler _imageHandler;

    public BodiesController(BodiesConnector bodiesConnector, ImageHandler imageHandler)
    {
      Connector = bodiesConnector;
      ImageHandler = imageHandler;
    }

    /// <summary>
    /// Returns an array of bodies (id, name & image url)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(OptionDTO[]))]
    public IHttpActionResult GetBodies()
    {
      var bodies = Connector.GetAllBodies();
      var dto = new List<OptionDTO>();
      bodies.ForEach(body =>
      {
        var uri = Url.Link("getBodyImageById", new {id = body.Id});
        dto.Add(OptionMapper.optionToDto(body, uri));
      });
      return Ok(dto);
    }

    /// <summary>
    /// The image url for the body with the given ID
    /// </summary>
    [HttpGet]
    [Route("{id}", Name = "getBodyImageById")]
    [ResponseType(typeof(object))]
    public HttpResponseMessage GetBodyImage(int id)
    {
      return ImageHandler.GetBodyImage(id);
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