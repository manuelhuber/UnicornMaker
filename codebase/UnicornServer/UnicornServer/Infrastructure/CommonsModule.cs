using Autofac;
using UnicornServer.Util;

namespace UnicornServer.Infrastructure
{
  public class CommonsModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      builder.Register(context => new ImageHandler()).AsSelf().SingleInstance();
    }
  }
}