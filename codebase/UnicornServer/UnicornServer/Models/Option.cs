namespace UnicornServer.Models
{
  public abstract class Option
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }

  public class Body : Option
  {
  }

  public class Hat : Option
  {
  }

  public class Wings : Option
  {
  }

  public class Shoes : Option
  {
  }
}