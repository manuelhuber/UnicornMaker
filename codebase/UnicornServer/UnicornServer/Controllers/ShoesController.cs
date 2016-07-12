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
  /// Rest Endpoint for everything related to shoes
  /// Autor: Franziska Haaf
  /// </summary>
  [RoutePrefix("v1/shoes")]
  public class ShoesController : ApiController
  {
    /// <summary>
    /// Connector to the database layer
    /// </summary>
    public ShoesConnector Connector { get; set; }

    /// <summary>
    /// Helper class for image streaming
    /// </summary>
    public ImageHandler ImageHandler { get; set; }

    /// <summary>
    /// Default constructor
    /// </summary>
    /// <param name="shoesConnector">To be injected</param>
    /// <param name="imageHandler">To be injected</param>
    public ShoesController(ShoesConnector shoesConnector, ImageHandler imageHandler)
    {
      Connector = shoesConnector;
      ImageHandler = imageHandler;
    }

    /// <summary>
    /// Returns an array of shoes (id + name)
    /// </summary>
    [HttpGet]
    [Route("")]
    [ResponseType(typeof(Option[]))]
    public IHttpActionResult GetShoes()
    {
      var shoes = Connector.GetAllShoes();
      var dto = new List<OptionDTO>();
      shoes.ForEach(shoe =>
      {
        var uri = Url.Link("getShoesImageById", new {id = shoe.Id});
        dto.Add(OptionMapper.optionToDto(shoe, uri));
      });
      return Ok(dto);
    }

    /// <summary>
    /// The image url for the shoes with the given ID
    /// </summary>
    [HttpGet]
    [Route("{id}", Name = "getShoesImageById")]
    [ResponseType(typeof(Object))]
    public HttpResponseMessage GetShoesImage(int id)
    {
      return ImageHandler.GetHatImage(id);
    }

    /// <summary>
    /// Not part of 1.0 release
    /// </summary>
    [HttpPost]
    [Route("")]
    [ResponseType(typeof(Option))]
    [Authorize]
    public IHttpActionResult AddShoes()
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
    public IHttpActionResult ModifyShoes()
    {
      return InternalServerError(new NotImplementedException());
    }
  }
}