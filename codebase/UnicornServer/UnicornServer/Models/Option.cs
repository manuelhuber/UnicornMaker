namespace UnicornServer.Models
{
  public abstract class Option
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }

  public class OptionDTO : Option
  {
    public string url { get; set; }
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

  public class OptionMapper
  {
    public static OptionDTO optionToDto(Option option, string url)
    {
      return new OptionDTO() {Id = option.Id, Name = option.Name, url = url};
    }
  }
}