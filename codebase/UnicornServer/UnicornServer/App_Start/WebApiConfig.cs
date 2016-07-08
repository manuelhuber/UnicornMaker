using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Autofac.Integration.WebApi;
using System.Web.Cors;
using System.Web.Http.Cors;
using UnicornServer.Infrastructure;

namespace UnicornServer
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      // Web API configuration and services

      // Web API routes
      config.MapHttpAttributeRoutes();

      var cors = new EnableCorsAttribute("www.example.com", "*", "*");
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