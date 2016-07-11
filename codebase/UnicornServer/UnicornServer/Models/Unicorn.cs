using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UnicornServer.Models
{
  public class Unicorn
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Name { get; set; }
    public int Body { get; set; }
    public int Hat { get; set; }
    public int Shoes { get; set; }
    public int Wings { get; set; }
  }
}