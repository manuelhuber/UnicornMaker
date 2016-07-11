using Autofac;
using UnicornServer.Connectors;
using UnicornServer.Models;

namespace UnicornServer.Infrastructure
{
  public class RepositoriesModule : Module
  {
    protected override void Load(ContainerBuilder builder)
    {
      //builder.RegisterType<InMemoryBookRepository>().As<IBookRepository>().InstancePerRequest();
      builder.Register(context => new DatabaseContext()).AsSelf().InstancePerRequest();
      builder.Register(context => new BodiesConnector(context.Resolve<DatabaseContext>())).AsSelf().InstancePerRequest();
      builder.Register(context => new HatsConnector(context.Resolve<DatabaseContext>())).AsSelf().InstancePerRequest();
      builder.Register(context => new ShoesConnector(context.Resolve<DatabaseContext>())).AsSelf().InstancePerRequest();
      builder.Register(context => new UnicornConnector(context.Resolve<DatabaseContext>())).AsSelf().InstancePerRequest();
      builder.Register(context => new WingsConnector(context.Resolve<DatabaseContext>())).AsSelf().InstancePerRequest();
    }
  }
}