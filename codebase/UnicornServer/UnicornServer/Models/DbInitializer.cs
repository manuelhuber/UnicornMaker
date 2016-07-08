using System.Data.Entity;

namespace UnicornServer.Models
{
  public class DbInitializer : DropCreateDatabaseAlways<DatabaseContext>
  {
    protected override void Seed(DatabaseContext context)
    {
      AddInitUsers(context);
      base.Seed(context);
    }

    private void AddInitUsers(DatabaseContext context)
    {
      context.Bodies.Add(new Body() {Id = 0, Name = "Green Wings"});
      context.Bodies.Add(new Body() {Id = 1, Name = "Blue Wings"});
      context.Bodies.Add(new Body() {Id = 2, Name = "Purple Wings"});
      context.Bodies.Add(new Body() {Id = 3, Name = "Red Wings"});
      context.Bodies.Add(new Body() {Id = 4, Name = "Yellow Wings"});
    }
  }
}