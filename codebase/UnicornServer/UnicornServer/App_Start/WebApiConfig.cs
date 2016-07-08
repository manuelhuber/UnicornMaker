using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Autofac.Integration.WebApi;
using System.Web.Cors;
using System.Web.Http.Cors;
using Newtonsoft.Json.Serialization;
using UnicornServer.Infrastructure;

namespace UnicornServer
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      var json = GlobalConfiguration.Configuration.Formatters.JsonFormatter;
      json.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

      // Web API configuration and services

      // Web API routes
      config.MapHttpAttributeRoutes();

      var cors = new EnableCorsAttribute("http://localhost:3000", "*", "*");
      config.EnableCors(cors);

      config.Routes.MapHttpRoute(
        name: "DefaultApi",
        routeTemplate: "api/{controller}/{id}",
        defaults: new {id = RouteParameter.Optional}
      );


      // Dependency Injection Configuration
      IoCContext.Initialize(config);
      config.DependencyResolver = new AutofacWebApiDependencyResolver(IoCContext.Container);
    }
  }
}