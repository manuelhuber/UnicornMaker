using System.Data.Entity;

namespace UnicornServer.Models
{
  public class DbInitializer : DropCreateDatabaseAlways<DatabaseContext>
  {
    protected override void Seed(DatabaseContext context)
    {
      AddWings(context);
      AddBodies(context);
      base.Seed(context);
    }

    private void AddWings(DatabaseContext context)
    {
      context.Wings.Add(new Wings() {Id = 0, Name = "Green Wings"});
      context.Wings.Add(new Wings() {Id = 1, Name = "Blue Wings"});
      context.Wings.Add(new Wings() {Id = 2, Name = "Purple Wings"});
      context.Wings.Add(new Wings() {Id = 3, Name = "Red Wings"});
      context.Wings.Add(new Wings() {Id = 4, Name = "Yellow Wings"});
    }

    private void AddBodies(DatabaseContext context)
    {
      context.Bodies.Add(new Body() {Id = 0, Name = "Pink Unicorn"});
      context.Bodies.Add(new Body() {Id = 1, Name = "Blue Unicorn"});
      context.Bodies.Add(new Body() {Id = 2, Name = "Green Unicorn"});
      context.Bodies.Add(new Body() {Id = 3, Name = "Purple Unicorn"});
      context.Bodies.Add(new Body() {Id = 4, Name = "Red Unicorn"});
      context.Bodies.Add(new Body() {Id = 5, Name = "Yellow Unicorn"});
    }
  }
}