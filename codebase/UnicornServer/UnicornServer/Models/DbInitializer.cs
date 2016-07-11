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
      context.Wings.Add(new Wings() {Id = 1, Name = "Blue Wings"});
      context.Wings.Add(new Wings() {Id = 2, Name = "Purple Wings"});
      context.Wings.Add(new Wings() {Id = 3, Name = "Red Wings"});
      context.Wings.Add(new Wings() {Id = 4, Name = "Yellow Wings"});
      context.Wings.Add(new Wings() {Id = 5, Name = "Green Wings"});
      context.Wings.Add(new Wings() {Id = 6, Name = "Pink Wings"});
    }

    private void AddBodies(DatabaseContext context)
    {
      context.Bodies.Add(new Body() {Id = 1, Name = "Blue Unicorn"});
      context.Bodies.Add(new Body() {Id = 2, Name = "Green Unicorn"});
      context.Bodies.Add(new Body() {Id = 3, Name = "Purple Unicorn"});
      context.Bodies.Add(new Body() {Id = 4, Name = "Red Unicorn"});
      context.Bodies.Add(new Body() {Id = 5, Name = "Yellow Unicorn"});
      context.Bodies.Add(new Body() {Id = 6, Name = "Pink Unicorn"});
    }

    private void AddShoes(DatabaseContext context)
    {
      context.Shoes.Add(new Shoes() {Id = 1, Name = "Blue Shoes"});
      context.Shoes.Add(new Shoes() {Id = 2, Name = "Purple Shoes"});
      context.Shoes.Add(new Shoes() {Id = 3, Name = "Red Shoes"});
    }

    private void AddHats(DatabaseContext context)
    {
      context.Hats.Add(new Hat() {Id = 1, Name = "Blue Hat"});
      context.Hats.Add(new Hat() {Id = 2, Name = "Purple Hat"});
      context.Hats.Add(new Hat() {Id = 3, Name = "Red Hat"});
      context.Hats.Add(new Hat() {Id = 4, Name = "Yellow Hat"});
    }
  }
}