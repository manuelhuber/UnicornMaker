using System;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Hosting;

namespace UnicornServer.Util
{
  public class ImageHandler
  {
    private readonly string _filesDirectory;
    // Fallback in case there is nothing in the AppSettings
    const string DefaultFileLocation = "Images";
    private const string AppSettingsKey = "ImageHandler.FilesLocation";

    public ImageHandler()
    {
      var fileLocation = ConfigurationManager.AppSettings[AppSettingsKey];
      _filesDirectory = string.IsNullOrWhiteSpace(fileLocation) ? DefaultFileLocation : fileLocation;
    }

    public HttpResponseMessage GetBodyImage(int id)
    {
      return GetHttpResponse("Body", id);
    }

    public HttpResponseMessage GetHatImage(int id)
    {
      return GetHttpResponse("Hat", id);
    }

    public HttpResponseMessage GetWingsImage(int id)
    {
      return GetHttpResponse("Wings", id);
    }

    public HttpResponseMessage GetShoesImage(int id)
    {
      return GetHttpResponse("Shoes", id);
    }

    private HttpResponseMessage GetHttpResponse(string folder, int id)
    {
      var path = "~/" + _filesDirectory + "/" + folder + "/" + folder + "_" + id + ".png";
      if (!Exists(id + ".jpg"))
      {
        return new HttpResponseMessage(HttpStatusCode.BadRequest);
      }

      var result = new HttpResponseMessage(HttpStatusCode.OK);
      var filePath = HostingEnvironment.MapPath(path);
      using (var fileStream = new FileStream(filePath, FileMode.Open))
      {
        var image = Image.FromStream(fileStream);
        var memoryStream = new MemoryStream();
        image.Save(memoryStream, ImageFormat.Jpeg);
        result.Content = new ByteArrayContent(memoryStream.ToArray());
        result.Content.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");

        return result;
      }
    }

    private bool Exists(string name)
    {
      //make sure we dont access directories outside of our store for security reasons
      var file = Directory.GetFiles(_filesDirectory, name, SearchOption.AllDirectories)
        .FirstOrDefault();
      return file != null;
    }
  }
}