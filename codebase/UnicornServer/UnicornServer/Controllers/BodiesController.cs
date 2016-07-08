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
  public class BodyController : ApiController
  {
    private readonly BodiesConnector _connector;
    private readonly ImageHandler _imageHandler;

//    BodyController(BodiesConnector bodyConnector, ImageHandler handler)
//    {
//      _connector = bodyConnector;
//      _imageHandler = handler;
//    }


    BodyController()
    {
      _connector = new BodiesConnector();
      _imageHandler = new ImageHandler();
    }

    /// <summary>
    /// Returns an array of bodies (id, name & image url)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(OptionDTO[]))]
    public IHttpActionResult GetBodies()
    {
      var bodies = _connector.GetAllBodies();
      var dto = new List<OptionDTO>();
      bodies.ForEach((Body body) =>
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
    [ResponseType(typeof(Object))]
    public HttpResponseMessage GetBodyImage(int id)
    {
      return _imageHandler.GetBodyImage(id);
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