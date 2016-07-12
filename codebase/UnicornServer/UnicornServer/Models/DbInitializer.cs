using System.Data.Entity;

namespace UnicornServer.Models
{
  public class DbInitializer : DropCreateDatabaseAlways<DatabaseContext>
  {
    protected override void Seed(DatabaseContext context)
    {
      AddWings(context);
      AddBodies(context);
      AddShoes(context);
      AddHats(context);
      base.Seed(context);
    }

    private void AddWings(DatabaseContext context)
    {
      context.Wings.Add(new Wings() {Id = 1, Name = "Rainmaker"});
      context.Wings.Add(new Wings() {Id = 2, Name = "Dreamweaver"});
      context.Wings.Add(new Wings() {Id = 3, Name = "Firey Wings"});
      context.Wings.Add(new Wings() {Id = 4, Name = "Angel's Grace"});
      context.Wings.Add(new Wings() {Id = 5, Name = "Forest Sails"});
      context.Wings.Add(new Wings() {Id = 6, Name = "Cupid's Joy"});
    }

    private void AddBodies(DatabaseContext context)
    {
      context.Bodies.Add(new Body() {Id = 1, Name = "Frosty"});
      context.Bodies.Add(new Body() {Id = 2, Name = "Leaf"});
      context.Bodies.Add(new Body() {Id = 3, Name = "Nightshade"});
      context.Bodies.Add(new Body() {Id = 4, Name = "Fire"});
      context.Bodies.Add(new Body() {Id = 5, Name = "York"});
      context.Bodies.Add(new Body() {Id = 6, Name = "Luv"});
    }

    private void AddShoes(DatabaseContext context)
    {
      context.Shoes.Add(new Shoes() {Id = 1, Name = "Pumps"});
      context.Shoes.Add(new Shoes() {Id = 2, Name = "Wellingtons"});
      context.Shoes.Add(new Shoes() {Id = 3, Name = "Socks"});
    }

    private void AddHats(DatabaseContext context)
    {
      context.Hats.Add(new Hat() {Id = 1, Name = "Crown"});
      context.Hats.Add(new Hat() {Id = 2, Name = "Old hat"});
      context.Hats.Add(new Hat() {Id = 3, Name = "Fes"});
      context.Hats.Add(new Hat() {Id = 4, Name = "Bow"});
    }
  }
}