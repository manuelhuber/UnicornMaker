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
  /// Rest Endpoint for everything related to wings
  /// Autor: Franziska Haaf
  /// </summary>
  [RoutePrefix("v1/wings")]
  public class WingsController : ApiController
  {
    /// <summary>
    /// Connector to the database layer
    /// </summary>
    public WingsConnector Connector { get; set; }

    /// <summary>
    /// Helper class for image streaming
    /// </summary>
    public ImageHandler ImageHandler { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="wingsConnector">To be injected</param>
    /// <param name="imageHandler">To be injected</param>
    public WingsController(WingsConnector wingsConnector, ImageHandler imageHandler)
    {
      Connector = wingsConnector;
      ImageHandler = imageHandler;
    }

    /// <summary>
    /// Returns an array of wings (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetWings()
    {
      var wings = Connector.GetAllWings();
      var dto = new List<OptionDTO>();
      wings.ForEach(wing =>
      {
        var uri = Url.Link("getWingsImageById", new {id = wing.Id});
        dto.Add(OptionMapper.optionToDto(wing, uri));
      });
      return Ok(dto);
    }

    /// <summary>
    /// The image url for the wings with the given ID
    /// </summary>
    [HttpGet]
    [Route("{id}", Name = "getWingsImageById")]
    [ResponseType(typeof(Object))]
    public HttpResponseMessage GetWingsImage(int id)
    {
      return ImageHandler.GetWingsImage(id);
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPost]
    [Route("")]
    [ResponseType(typeof(Option))]
    [Authorize]
    public IHttpActionResult AddWings()
    {
      return InternalServerError(new NotImplementedException());
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPut]
    [Route("{id}")]
    [ResponseType(typeof(Option))]
    [Authorize]
    public IHttpActionResult ModifyWings()
    {
      return InternalServerError(new NotImplementedException());
    }
  }
}